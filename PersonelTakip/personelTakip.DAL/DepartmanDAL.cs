using MySql.Data.MySqlClient;
using personelTakip.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personelTakip.DAL
{
    public class DepartmanDAL
    {

        public static DataTable TumDepartmanlar()
        {
            DataTable dt = new DataTable();
            

            using (MySqlConnection con = Db.GetConnection())
            {
                string sql = "SELECT id, departmanAdi FROM departmanlar";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                da.Fill(dt);
            }

            return dt;
        }

        public static void DepartmanSil(int id)
        {
            string sql = "DELETE FROM departmanlar WHERE id=@id";

            using (MySqlConnection con = Db.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


            public static void DepartmanEkle(string departmanAdi)
        {
            string sql = "INSERT INTO departmanlar (departmanAdi) VALUES (@adi)";

            using (MySqlConnection con = Db.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@adi", departmanAdi);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}



