using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personelTakip.DAL
{
    public class Performans
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public int Puan { get; set; }
        public DateTime Tarih { get; set; }
    }
}
