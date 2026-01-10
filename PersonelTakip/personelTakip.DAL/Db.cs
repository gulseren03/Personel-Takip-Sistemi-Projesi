using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace personelTakip.DAL
{
    public static class Db
    {
        private static string _connectionString =
                   "Server=172.21.54.253;Database=26_132430007;User Id=26_132430007;Password=İnif123.;SslMode=Required;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
