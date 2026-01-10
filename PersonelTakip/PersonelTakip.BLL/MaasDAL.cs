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
    public static class MaasDAL
    {
        public static void MaasKaydet(int personelId, decimal netMaas)
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                con.Open();

                string sql = @"UPDATE Personeller 
                       SET maas = @maas 
                       WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@maas", netMaas);
                cmd.Parameters.AddWithValue("@id", personelId);

                cmd.ExecuteNonQuery();
            }
        }
        public static decimal OrtalamaMaas()
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                con.Open();

                string sql = "SELECT IFNULL(AVG(netMaas),0) FROM maaslar";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                object sonuc = cmd.ExecuteScalar();
                return Convert.ToDecimal(sonuc);
            }
        }

    }
}
    

    



