using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personelTakip.DAL
{
   public class Maas
    {
        public int personelId { get; set; }
        public decimal brutMaas { get; set; }
        public decimal netMaas { get; set; }
        public decimal prim { get; set; }
        public decimal kesinti { get; set; }
        public DateTime tarih { get; set; }

    }
}
