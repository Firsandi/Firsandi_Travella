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

        public void UpdateGuide(GuideModels guide)
        {
            using (var conn = _dbKoneksi.Database())
            {
                conn.Open();
                string query = "UPDATE guides SET nama = @nama, kontak = @kontak, WHERE id = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", guide.Nama);
                    cmd.Parameters.AddWithValue("@kontak", guide.Kontak);
                    cmd.Parameters.AddWithValue("@id", guide.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteGuide(int id)
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123;Database=PBO"))
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


    }
}
