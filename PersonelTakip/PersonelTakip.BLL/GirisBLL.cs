using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using personelTakip.DAL;

namespace PersonelTakip.BLL
{
    public class GirisBLL
    {
        public Personeller GirisYap(string kullaniciAdi, string şifre)
        {
            return PersonellerDAL.GirisYap(kullaniciAdi, şifre);
        }
    }
}
