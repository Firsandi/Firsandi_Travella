using Firsandi_Travella.Models;
using Firsandi_Travella.Interfaces;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Firsandi_Travella.Database
{
    public class PemesananRepository
    {
        private readonly KoneksiDatabase _dbKoneksi = new();

        public bool SimpanPemesananLangsung(PemesananModels model)
        {
            using var conn = _dbKoneksi.Database();
            conn.Open();
            using var trx = conn.BeginTransaction();

            try
            {
                decimal jumlah = GetHargaPaket(model.PaketId);

                string sqlPemesanan = @"INSERT INTO pemesanans 
            (user_id, paket_id, guide_id, metode_id, tanggal_keberangkatan, tanggal_pemesanan, status_pemesanan)
            VALUES (@user_id, @paket_id, @guide_id, @metode_id, @tanggal, @tanggal_pemesanan, 'Berhasil')
            RETURNING pemesanan_id";

                using var cmdP = new NpgsqlCommand(sqlPemesanan, conn);
                cmdP.Parameters.AddWithValue("user_id", model.UserId);
                cmdP.Parameters.AddWithValue("paket_id", model.PaketId);
                cmdP.Parameters.AddWithValue("guide_id", model.GuideId);
                cmdP.Parameters.AddWithValue("metode_id", model.MetodeId);
                cmdP.Parameters.AddWithValue("tanggal", model.TanggalKeberangkatan);
                cmdP.Parameters.AddWithValue("tanggal_pemesanan", DateTime.Now);

                int pemesananId = Convert.ToInt32(cmdP.ExecuteScalar());

                string sqlTransaksi = @"INSERT INTO transaksi_pembayarans 
            (pemesanan_id, metode_id, jumlah, status, tanggal_pembayaran)
            VALUES (@pemesanan_id, @metode_id, @jumlah, 'Berhasil', NOW())";

                using var cmdT = new NpgsqlCommand(sqlTransaksi, conn);
                cmdT.Parameters.AddWithValue("pemesanan_id", pemesananId);
                cmdT.Parameters.AddWithValue("metode_id", model.MetodeId);
                cmdT.Parameters.AddWithValue("jumlah", jumlah);
                cmdT.ExecuteNonQuery();

                trx.Commit();
                return true;
            }
            catch
            {
                trx.Rollback();
                return false;
            }
        }

        public List<MetodePembayaranModels> GetMetode()
        {
            List<MetodePembayaranModels> list = new();
            using var conn = _dbKoneksi.Database();
            conn.Open();
            string sql = "SELECT metode_pembayaran_id, nama_metode, jenis FROM metode_pembayarans";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new MetodePembayaranModels
                {
                    Id = reader.GetInt32(0),
                    Nama = reader.GetString(1),
                    Jenis = reader.GetString(2)
                });
            }
            return list;
        }

        public List<BankTransferModels> GetBankByMetode(int metodeId)
        {
            List<BankTransferModels> list = new();
            using var conn = _dbKoneksi.Database();
            conn.Open();
            string sql = "SELECT nama_bank, nomor_rekening FROM bank_transfer WHERE metode_id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", metodeId);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new BankTransferModels
                {
                    NamaBank = reader.GetString(0),
                    NomorRekening = reader.GetString(1)
                });
            }
            return list;
        }

        public BankTransferModels GetRekening(int metodeId)
        {
            using var conn = _dbKoneksi.Database();
            conn.Open();
            string sql = "SELECT nama_bank, nomor_rekening FROM bank_transfer WHERE metode_id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", metodeId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new BankTransferModels
                {
                    NamaBank = reader.GetString(0),
                    NomorRekening = reader.GetString(1)
                };
            }
            return null;
        }

        public bool UpdateStatusPemesanan(int id, string status)
        {
            using var conn = _dbKoneksi.Database();
            conn.Open();
            string sql = @"UPDATE pemesanans 
                           SET status_pemesanan = @status, tanggal_pemesanan = NOW() 
                           WHERE pemesanan_id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("status", status);
            cmd.Parameters.AddWithValue("id", id);
            return cmd.ExecuteNonQuery() > 0;
        }
        public decimal GetHargaPaket(int paketId)
        {
            using var conn = _dbKoneksi.Database();
            conn.Open();

            string sql = "SELECT harga FROM paket_trips WHERE paket_id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", paketId);

            var result = cmd.ExecuteScalar();
            return result != null ? Convert.ToDecimal(result) : 0;
        }
    }
}
