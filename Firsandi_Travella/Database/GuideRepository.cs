using Firsandi_Travella.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Database
{
    public class GuideRepository
    {
        private readonly KoneksiDatabase _dbKoneksi;

        public GuideRepository()
        {
            _dbKoneksi = new KoneksiDatabase();
        }

        public List<GuideModels> GetGuides()
        {
            List<GuideModels> guides = new List<GuideModels>();

            using (var conn = _dbKoneksi.Database())
            {
                conn.Open();
                string query = "SELECT guide_id, nama, kontak FROM guides";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        guides.Add(new GuideModels
                        {
                            Id = reader.GetInt32(0),
                            Nama = reader.GetString(1),
                            Kontak = reader.GetString(2),
                        });
                    }
                }
            }

            return guides;
        }


        public bool TambahGuide(GuideModels guide)
        {
            using (var conn = _dbKoneksi.Database())
            {
                conn.Open();
                string query = "INSERT INTO guides (nama, kontak) VALUES (@nama, @kontak )";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", guide.Nama);
                    cmd.Parameters.AddWithValue("@kontak", guide.Kontak);
                    bool success = cmd.ExecuteNonQuery() > 0;
                    return success;
                }

            }
            
        }

        public bool UpdateGuide(GuideModels guide)
        {
            using (var conn = _dbKoneksi.Database())
            {
                conn.Open();
                string query = "UPDATE guides SET nama = @nama, kontak = @kontak WHERE guide_id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", guide.Nama);
                    cmd.Parameters.AddWithValue("@kontak", guide.Kontak);
                    cmd.Parameters.AddWithValue("@id", guide.Id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public void DeleteGuide(int id)
        {
            using (var conn = _dbKoneksi.Database())
            {
                conn.Open();
                string query = "DELETE FROM guides WHERE guide_id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool CekGuide(int guideId)
        {
            using (var conn = _dbKoneksi.Database())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM paket_trips WHERE guide_id = @guideId";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@guideId", guideId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0; // 🔥 Jika count > 0, berarti guide sedang digunakan
                }
            }
        }



    }
}
