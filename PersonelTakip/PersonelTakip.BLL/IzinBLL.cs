using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using personelTakip.DAL;

namespace PersonelTakip.BLL
{
    public static class IzinBLL
    {
        public static void IzinTalepEt(Izin izin)
        {
            if (izin == null)
                throw new Exception("İzin bilgisi boş olamaz.");

            if (izin.PersonelId <= 0)
                throw new Exception("Personel seçilmedi.");

            if (izin.BitisTarihi < izin.BaslangicTarihi)
                throw new Exception("Bitiş tarihi başlangıçtan küçük olamaz.");

            if (string.IsNullOrWhiteSpace(izin.Aciklama))
                throw new Exception("Açıklama boş olamaz.");

            int gunSayisi =
                (izin.BitisTarihi - izin.BaslangicTarihi).Days + 1;

            if (gunSayisi > 14)
                throw new Exception("İzin süresi 14 günü geçemez.");

            if (string.IsNullOrEmpty(izin.Durum))
                izin.Durum = "Beklemede";

            IzinDAL.IzinEkle(izin);
        }
    }
    
}



