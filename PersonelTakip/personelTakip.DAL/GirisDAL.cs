using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using personelTakip.DAL;


namespace personelTakip.DAL
{
    public static class GirisDAL
    {

        public static string GirisYap(string kullaniciAdi, string sifre)
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                con.Open();

                string sql = @"SELECT rol FROM Personeller
                               WHERE kullaniciAdi=@k
                               AND sifre=@s";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@k", kullaniciAdi);
                cmd.Parameters.AddWithValue("@s", sifre);

                object sonuc = cmd.ExecuteScalar();
                return sonuc?.ToString();
            }
        }
    }
}

