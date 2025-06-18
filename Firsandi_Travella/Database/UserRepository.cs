using Firsandi_Travella.Database;
using Firsandi_Travella.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Database
{

    public class UserRepository
    {
        private readonly KoneksiDatabase _dbKoneksi;

        public UserRepository()
        {
            _dbKoneksi = new KoneksiDatabase();
        }

        public bool ValidasiUser(string username, string password)
        {
            using (var conn = _dbKoneksi.Database())
            {
                conn.Open();
                string sql = "SELECT user_id FROM users WHERE username = @username AND password = @password";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    using (var reader = cmd.ExecuteReader())
                    {
                        return reader.Read();
                    }
                }
            }
            return false;
        }
        public bool SimpanUser(string nama, string email, string nomor, string username, string password)
        {
            using (var conn = _dbKoneksi.Database())
            {
                conn.Open();
                string sql = "INSERT INTO users (nama, email, no_telepon, username, password) VALUES (@nama, @email, @nomor, @username, @password)";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nama", nama);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("nomor", nomor);
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    return cmd.ExecuteNonQuery() > 0; // Berhasil jika lebih dari 0 baris terpengaruh
                }
            }
        }
        public UserModels GetUserByLogin(string username, string password)
        {
            using var conn = _dbKoneksi.Database();
            conn.Open();

            string sql = "SELECT * FROM users WHERE username = @username AND password = @password"; // Pastikan password sudah di-hash!
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new UserModels
                {
                    Id = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2) // Jika simpan hash, lebih baik jangan kembalikan ini
                };
            }

            return null; // ✅ Menangani kasus user tidak ditemukan
        }


    }
}