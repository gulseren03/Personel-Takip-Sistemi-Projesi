using MySql.Data.MySqlClient;
using personelTakip.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personelTakip.DAL
{
    public static class PerformansDAL
    {
        public static void PerformansEkle(Performans p)
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                con.Open();

                string sql = @"INSERT INTO performanslar
                           (personelId, puan, tarih)
                           VALUES (@pid, @puan, @tarih)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pid", p.PersonelId);
                cmd.Parameters.AddWithValue("@puan", p.Puan);
                cmd.Parameters.AddWithValue("@tarih", p.Tarih);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
