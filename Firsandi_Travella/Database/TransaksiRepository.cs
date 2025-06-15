using Firsandi_Travella.Models;
using Firsandi_Travella.Interfaces;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Database
{
    public class TransaksiRepository
    {
        private readonly KoneksiDatabase _dbKoneksi;

        public TransaksiRepository()
        {
            _dbKoneksi = new KoneksiDatabase();
        }

        public bool SimpanTransaksi(TransaksiModels model)
        {
            using var conn = _dbKoneksi.Database();
            conn.Open();
            string sql = @"INSERT INTO transaksi_pembayarans 
                (pemesanan_id, metode_id, jumlah)
                VALUES (@pemesanan_id, @metode_id, @jumlah)";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("pemesanan_id", model.PemesananId);
            cmd.Parameters.AddWithValue("metode_id", model.MetodeId);
            cmd.Parameters.AddWithValue("jumlah", model.Jumlah);
            return cmd.ExecuteNonQuery() > 0;
        }
        public bool UpdateStatusPembayaran(int transaksiId, string status)
        {
            using var conn = _dbKoneksi.Database();
            conn.Open();
            string sql = @"UPDATE transaksi_pembayarans SET status = @status WHERE transaksi_id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("status", status);
            cmd.Parameters.AddWithValue("id", transaksiId);
            return cmd.ExecuteNonQuery() > 0;
        }

        public List<TransaksiModels> GetRiwayatUser(int userId)
        {
            List<TransaksiModels> list = new();
            using var conn = _dbKoneksi.Database();
            conn.Open();
            string sql = @"
                SELECT tp.transaksi_id, pt.nama, tp.jumlah, mp.nama_metode, tp.status, tp.tanggal_pembayaran
                FROM transaksi_pembayarans tp
                JOIN pemesanans p ON tp.pemesanan_id = p.pemesanan_id
                JOIN paket_trips pt ON p.paket_id = pt.paket_id
                JOIN metode_pembayarans mp ON tp.metode_id = mp.metode_pembayaran_id
                WHERE p.user_id = @user_id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("user_id", userId);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new TransaksiModels
                {
                    TransaksiId = reader.GetInt32(0),
                    PemesananId = reader.GetInt32(1),
                    MetodeId = reader.GetInt32(2),
                    Jumlah = reader.GetDecimal(3),
                    Status = reader.GetString(4),
                    TanggalPembayaran = reader.GetDateTime(5)
                });
            }
            return list;
        }

        public List<TransaksiModels> GetSemuaTransaksi()
        {
            List<TransaksiModels> list = new();
            using var conn = _dbKoneksi.Database();
            conn.Open();
            string sql = @"
                SELECT tp.transaksi_id, u.nama, pt.nama, tp.jumlah, mp.nama_metode, tp.status, tp.tanggal_pembayaran
                FROM transaksi_pembayarans tp
                JOIN pemesanans p ON tp.pemesanan_id = p.pemesanan_id
                JOIN users u ON p.user_id = u.user_id
                JOIN paket_trips pt ON p.paket_id = pt.paket_id
                JOIN metode_pembayarans mp ON tp.metode_id = mp.metode_pembayaran_id";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new TransaksiModels
                {
                    TransaksiId = reader.GetInt32(0),           // tp.transaksi_id
                    NamaUser = reader.GetString(1),             // u.nama
                    NamaPaket = reader.GetString(2),            // pt.nama
                    Jumlah = reader.GetDecimal(3),              // tp.jumlah
                    Metode = reader.GetString(4),               // mp.nama_metode
                    Status = reader.GetString(5),               // tp.status
                    TanggalPembayaran = reader.GetDateTime(6)   // tp.tanggal_pembayaran
                });
            }
            return list;
        }
        public bool HapusPemesanan(int pemesananId)
        {
            using var conn = _dbKoneksi.Database();
            conn.Open();
            string sql = @"
            DELETE FROM pemesanans 
            WHERE pemesanan_id = @id 
            AND pemesanan_id NOT IN (SELECT pemesanan_id FROM transaksi_pembayarans)";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", pemesananId);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
