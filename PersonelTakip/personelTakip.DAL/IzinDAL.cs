using MySql.Data.MySqlClient;
using personelTakip.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 


namespace personelTakip.DAL
{
    public static class IzinDAL
    {
        public static void IzinEkle(Izin izin)
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                con.Open();

                string sql = @"INSERT INTO izinler
                               (personelId, baslangıc, bitis, acıklama, durum)
                               VALUES
                               (@pid, @bas, @bit, @acik, @durum)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@pid", izin.PersonelId);
                cmd.Parameters.AddWithValue("@bas", izin.BaslangicTarihi);
                cmd.Parameters.AddWithValue("@bit", izin.BitisTarihi);
                cmd.Parameters.AddWithValue("@acik", izin.Aciklama);
                cmd.Parameters.AddWithValue("@durum", izin.Durum);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
    



