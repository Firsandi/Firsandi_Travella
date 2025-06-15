using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Firsandi_Travella.Database
{
    public class KoneksiDatabase
    {
        private readonly string _connectionString;

        public KoneksiDatabase()
        {
            _connectionString = "Host=localhost;Username=postgres;Password=123;Database=TRAVELLA_PBO;";
        }

        public NpgsqlConnection Database()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}
