using Org.BouncyCastle.Asn1.X509;
using personelTakip.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace personelTakip.DAL
{
    public class Izin
    {
     
       public int PersonelId { get; set; }
       public DateTime BaslangicTarihi { get; set; }
       public DateTime BitisTarihi { get; set; }
       public string Aciklama { get; set; }
       public string Durum { get; set; }




    }
}
