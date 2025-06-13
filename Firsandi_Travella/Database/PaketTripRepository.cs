using Firsandi_Travella.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Database
{
    public class PaketTripRepository
    {
        private readonly KoneksiDatabase _dbKoneksi;

        public PaketTripRepository()
        {
            _dbKoneksi = new KoneksiDatabase();
        }

        public List<PaketTripModels> AmbilSemuaPaketTrip()
        {
            List<PaketTripModels> paketTrips = new List<PaketTripModels>();

            using (var conn = _dbKoneksi.Database())
            {
                conn.Open();
                string sql = "SELECT id, nama, harga, deskripsi, gambar_path FROM paket_trips";

                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        paketTrips.Add(new PaketTripModels
                        {
                            Id = reader.GetInt32(0),
                            Nama = reader.GetString(1),
                            Harga = reader.GetDecimal(2),
                            Deskripsi = reader.GetString(3),
                            GambarPath = reader.GetString(4)
                        });
                    }
                }
            }

            return paketTrips;
        }

        public bool TambahPaketTrip(PaketTripModels paket)
        {
            using (var conn = _dbKoneksi.Database())
            {
                conn.Open();
                string sql = "INSERT INTO paket_trips (nama, harga, deskripsi, gambar_path) VALUES (@nama, @harga, @deskripsi, @gambar_path)";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nama", paket.Nama);
                    cmd.Parameters.AddWithValue("harga", paket.Harga);
                    cmd.Parameters.AddWithValue("deskripsi", paket.Deskripsi);
                    cmd.Parameters.AddWithValue("gambar_path", paket.GambarPath);
                    cmd.Parameters.AddWithValue("@guideId", paket.GuideId);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool HapusPaketTrip(int id)
        {
            using (var conn = _dbKoneksi.Database())
            {
                conn.Open();
                string sql = "DELETE FROM paket_trips WHERE id = @id";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public void UpdatePaketTrip(PaketTripModels trip)
        {
            using (var conn = _dbKoneksi.Database()) // 🔥 Gunakan koneksi dari `KoneksiDatabase`
            {
                conn.Open();
                string query = "UPDATE paket_trips SET nama = @nama, harga = @harga, guide_id = @guide, deskripsi = @deskripsi, gambar_path = @gambar WHERE id = @id";

                using (var cmd = new NpgsqlCommand(query, conn)) // 🔥 Gunakan `conn`, bukan `_dbKoneksi`
                {
                    cmd.Parameters.AddWithValue("@nama", trip.Nama);
                    cmd.Parameters.AddWithValue("@harga", trip.Harga);
                    cmd.Parameters.AddWithValue("@guide", trip.GuideId);
                    cmd.Parameters.AddWithValue("@deskripsi", trip.Deskripsi);
                    cmd.Parameters.AddWithValue("@gambar", trip.GambarPath);
                    cmd.Parameters.AddWithValue("@id", trip.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
