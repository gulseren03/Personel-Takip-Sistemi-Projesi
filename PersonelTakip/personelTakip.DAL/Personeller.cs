
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personelTakip.DAL
{

    public class Personeller
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }   
        public string Sifre { get; set; }         
        public string Rol { get; set; }

        public int DepartmanId { get; set; }
         public decimal Maas {  get; set; }
        public DateTime IseGirisTarihi { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
       
    }
}

    




