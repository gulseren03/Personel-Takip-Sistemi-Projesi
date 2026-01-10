using personelTakip.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip.BLL
{
    public class MaasBLL
    {
        public static decimal NetMaasHesapla(decimal brut, decimal primYuzde, decimal kesintiYuzde)
        {
            if (brut <= 0)
                throw new Exception("Brüt maaş sıfırdan büyük olmalı.");

            if (primYuzde < 0 || kesintiYuzde < 0)
                throw new Exception("Prim ve kesinti negatif olamaz.");

            decimal primTutar = brut * primYuzde / 100;
            decimal kesintiTutar = brut * kesintiYuzde / 100;

            return brut + primTutar - kesintiTutar;
        }

        public static void MaasKaydet(int personelId, decimal brut, decimal primYuzde, decimal kesintiYuzde)
        {
            decimal netMaas = NetMaasHesapla(brut, primYuzde, kesintiYuzde);
            MaasDAL.MaasKaydet(personelId, netMaas);
        }

        public static decimal OrtalamaMaasGetir()
        {
            return MaasDAL.OrtalamaMaas();
        }

    }
}
