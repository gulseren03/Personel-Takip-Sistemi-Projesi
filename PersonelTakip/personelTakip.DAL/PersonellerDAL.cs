using MySql.Data.MySqlClient;
using Mysqlx;
using personelTakip.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personelTakip.DAL
{
    public static class PersonellerDAL
    {
        public static void PersonelEkle(Personeller p)
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                con.Open();

                string sql = @"INSERT INTO Personeller
                               (ad, soyad, kullaniciAdi, şifre, rol, departmanId,maas,iseGirisTarihi)
                               VALUES
                               (@ad, @soyad, @kAdi, @sifre, @rol, @depId,@maas,@iseGiris)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ad", p.Ad);
                cmd.Parameters.AddWithValue("@soyad", p.Soyad);
                cmd.Parameters.AddWithValue("@kAdi", p.KullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", p.Sifre);
                cmd.Parameters.AddWithValue("@rol", p.Rol);
                cmd.Parameters.AddWithValue("@depId", p.DepartmanId);
                cmd.Parameters.AddWithValue("@maas", 0);
                cmd.Parameters.AddWithValue("@iseGiris", p.IseGirisTarihi);




                cmd.ExecuteNonQuery();
            }
        }
        public static Personeller GirisYap(string kullaniciAdi, string şifre)
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                con.Open();

                string sql = @"SELECT * FROM Personeller
                       WHERE kullaniciAdi=@k
                       AND şifre=@s";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@k", kullaniciAdi);
                cmd.Parameters.AddWithValue("@s", şifre);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new Personeller
                    {
                        Id = Convert.ToInt32(dr["id"]),
                        Ad = dr["ad"].ToString(),
                        Rol = dr["rol"].ToString()
                    };
                }
            }
            return null;
        }
        


        public static DataTable MaasListesiGetir()
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                string sql = "SELECT ad, soyad, maas FROM Personeller";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public static decimal ToplamMaas()
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                con.Open();
                MySqlCommand cmd =
                    new MySqlCommand("SELECT SUM(maas) FROM Personeller", con);

                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        public static decimal OrtalamaMaas()
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                con.Open();

                MySqlCommand cmd =
                    new MySqlCommand("SELECT AVG(maas) FROM Personeller", con);

                object sonuc = cmd.ExecuteScalar();

                if (sonuc == DBNull.Value)
                    return 0;

                return Convert.ToDecimal(sonuc);
            }
        }
     

        public static DataTable TumPersoneller()
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                string sql = "SELECT id, ad FROM Personeller";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public static DataTable DepartmanaGorePersoneller(int departmanId)
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                string sql =
                    "SELECT ad, soyad FROM Personeller WHERE departmanId=@id";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@id", departmanId);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}

    

      
    



    



