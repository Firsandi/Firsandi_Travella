using Firsandi_Travella.Models;
using Firsandi_Travella.Interfaces;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Firsandi_Travella.Database
{
    public class PemesananRepository
    {

            private readonly KoneksiDatabase _dbKoneksi;

            public PemesananRepository()
            {
                _dbKoneksi = new KoneksiDatabase();
            }

            public int SimpanPemesanan(PemesananModels model)
            {
                using var conn = _dbKoneksi.Database();
                conn.Open();

                string sql = @"
                INSERT INTO pemesanans (user_id, guide_id, paket_id, tanggal_keberangkatan, jadwal_keberangkatan, metode_pembayaran, status_pembayaran) 
                VALUES (@user_id, @guide_id, @paket_id, @tanggal_keberangkatan, @jadwal_keberangkatan, @metode_pembayaran, @status_pembayaran)
                RETURNING pemesanan_id";

                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("user_id", model.UserId);
                cmd.Parameters.AddWithValue("guide_id", model.GuideId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("paket_id", model.PaketId);
                cmd.Parameters.AddWithValue("tanggal_keberangkatan", model.TanggalKeberangkatan);
                cmd.Parameters.AddWithValue("jadwal_keberangkatan", model.JadwalKeberangkatan);
                cmd.Parameters.AddWithValue("metode_pembayaran", model.MetodePembayaran);
                cmd.Parameters.AddWithValue("status_pembayaran", model.StatusPembayaran);

                return Convert.ToInt32(cmd.ExecuteScalar()); // ✅ Mengambil ID pemesanan yang baru dibuat
            }

            public List<PemesananModels> GetRiwayatUser(int userId)
            {
                List<PemesananModels> riwayat = new List<PemesananModels>();

                using var conn = _dbKoneksi.Database();
                conn.Open();

                string sql = "SELECT * FROM pemesanans WHERE user_id = @user_id ORDER BY pemesanan_id DESC";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("user_id", userId);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    riwayat.Add(new PemesananModels
                    {
                        PemesananId = reader.GetInt32(0),
                        UserId = reader.GetInt32(1),
                        GuideId = reader.IsDBNull(2) ? null : reader.GetInt32(2),
                        PaketId = reader.GetInt32(3),
                        TanggalKeberangkatan = reader.GetDateTime(4),
                        JadwalKeberangkatan = reader.GetString(5),
                        MetodePembayaran = reader.GetString(6),
                        StatusPembayaran = reader.GetString(7)
                    });
                }
                return riwayat;
            }
        public List<PemesananModels> GetPemesananByUser(int userId)
        {
            var list = new List<PemesananModels>();
            using var conn = _dbKoneksi.Database();
            conn.Open();

            string sql = @"
        SELECT 
            p.pemesanan_id, p.paket_id, pk.nama AS nama_paket,
            p.tanggal_keberangkatan, p.jadwal_keberangkatan,
            p.metode_pembayaran, p.status_pembayaran,
            COALESCE(p.nominal_transfer, pk.harga) AS nominal_transfer
        FROM pemesanans p
        JOIN paket_trips pk ON pk.paket_id = p.paket_id
        WHERE p.user_id = @userId";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("userId", userId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new PemesananModels
                {
                    PemesananId = reader.GetInt32(0),
                    PaketId = reader.GetInt32(1),
                    Nama = reader.GetString(2),
                    TanggalKeberangkatan = reader.GetDateTime(3),
                    JadwalKeberangkatan = reader.GetString(4),
                    MetodePembayaran = reader.GetString(5),
                    StatusPembayaran = reader.GetString(6),
                    NominalPembayaran = reader.GetDecimal(7)
                });
            }

            return list;
        }
        public List<PemesananModels> GetSemuaPemesanan()
        {
            var list = new List<PemesananModels>();
            using var conn = _dbKoneksi.Database();
            conn.Open();

            string sql = @"
        SELECT 
            p.pemesanan_id, 
            u.nama AS username, 
            pk.nama AS nama_paket,
            p.tanggal_keberangkatan,
            p.status_pembayaran
        FROM pemesanans p
        JOIN users u ON u.user_id = p.user_id
        JOIN paket_trips pk ON pk.paket_id = p.paket_id";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new PemesananModels
                {
                    PemesananId = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Nama = reader.GetString(2),
                    TanggalKeberangkatan = reader.GetDateTime(3),
                    StatusPembayaran = reader.GetString(4)
                });
            }

            return list;
        }

        public void UpdateStatusPembayaran(int pemesananId, string statusBaru)
        {
            using var conn = _dbKoneksi.Database();
            conn.Open();

            string sql = "UPDATE pemesanans SET status_pembayaran = @status WHERE pemesanan_id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("status", statusBaru);
            cmd.Parameters.AddWithValue("id", pemesananId);
            cmd.ExecuteNonQuery();
        }

        public void HapusPemesanan(int pemesananId)
        {
            using var conn = _dbKoneksi.Database();
            conn.Open();

            string sql = "DELETE FROM pemesanans WHERE pemesanan_id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", pemesananId);
            cmd.ExecuteNonQuery();
        }




    }
}

