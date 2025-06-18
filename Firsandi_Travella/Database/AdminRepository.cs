using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Database
{
    namespace Firsandi_Travella.Database
    {
        public class AdminRepository
        {
            private readonly KoneksiDatabase _dbKoneksi;

            public AdminRepository()
            {
                _dbKoneksi = new KoneksiDatabase();
            }

            public bool ValidasiAdmin(string username, string password)
            {
                using (var conn = _dbKoneksi.Database())
                {
                    conn.Open();
                    string sql = "SELECT admin_id FROM admins WHERE username = @username AND password = @password";

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
        }
    }


}
