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
        private readonly NpgsqlConnection _dbKoneksi;

        public GuideRepository()
        {
            _dbKoneksi = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123;Database=PBO");
        }

        public List<GuideModels> GetGuides()
        {
            List<GuideModels> guides = new List<GuideModels>();
            string query = "SELECT guide_id, nama, kontak FROM guides";

            using (var cmd = new NpgsqlCommand(query, _dbKoneksi))
            {
                _dbKoneksi.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        guides.Add(new GuideModels
                        {
                            Id = reader.GetInt32(0),
                            Nama = reader.GetString(1),
                            Kontak = reader.GetString(2)
                        });
                    }
                }
                _dbKoneksi.Close();
            }

            return guides;
        }

        public bool TambahGuide(GuideModels guide)
        {
            string query = "INSERT INTO guides (nama, kontak) VALUES (@nama, @kontak)";
            using (var cmd = new NpgsqlCommand(query, _dbKoneksi))
            {
                cmd.Parameters.AddWithValue("@nama", guide.Nama);
                cmd.Parameters.AddWithValue("@kontak", guide.Kontak);

                _dbKoneksi.Open();
                bool success = cmd.ExecuteNonQuery() > 0;
                _dbKoneksi.Close();
                return success;
            }
        }
    }
}
