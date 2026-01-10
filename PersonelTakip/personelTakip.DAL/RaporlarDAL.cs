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
        public static class RaporlarDAL
        {
            public static DataTable DepartmanDagilim()
            {
            string sql = @"SELECT d.departmanAdi, COUNT(p.id) AS PersonelSayisi
                           FROM departmanlar d
                           LEFT JOIN Personeller p ON p.departmanId = d.id
                           GROUP BY d.departmanAdi";

            using (MySqlConnection con = Db.GetConnection())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable IzinRaporu(DateTime bas, DateTime bit)
        {
            string sql = @"SELECT p.ad, p.soyad, i.baslangıc, i.bitis, i.durum
                           FROM izinler i
                           JOIN Personeller p ON p.id = i.personelId
                           WHERE i.baslangıc <= @bas
                           AND i.bitis >= @bit";

            using (MySqlConnection con = Db.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@bas", bas);
                cmd.Parameters.AddWithValue("@bit", bit);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable MaasRaporu()
        {
            string sql = @"SELECT 
                           SUM(netMaas) AS ToplamMaas,
                           AVG(netMaas) AS OrtalamaMaas 
                           FROM maaşlar";

            using (MySqlConnection con = Db.GetConnection())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable PerformansRaporu()
        {
            string sql = @"
            (
                SELECT p.ad AS Ad, p.soyad AS Soyad, pr.puan AS Puan
                FROM performanslar pr
                JOIN Personeller p ON p.id = pr.personelId
                ORDER BY pr.puan DESC
                LIMIT 1
            )
            UNION ALL
            (
                SELECT p.ad AS Ad, p.soyad AS Soyad, pr.puan AS Puan
                FROM performanslar pr
                JOIN Personeller p ON p.id = pr.personelId
                ORDER BY pr.puan ASC
                LIMIT 1
            )";

            using (MySqlConnection con = Db.GetConnection())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable IzinHakEdis()
        {
            string sql = @"
            SELECT 
                p.ad AS Ad,
                p.soyad AS Soyad,
                IFNULL(14 - SUM(DATEDIFF(i.bitis, i.baslangıc) + 1), 14) AS KalanIzin
            FROM Personeller p
            LEFT JOIN izinler i 
                ON p.id = i.personelId 
                AND i.durum = 'Onaylandı'
            GROUP BY p.id
            HAVING KalanIzin > 0";

            using (MySqlConnection con = Db.GetConnection())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
        
    


