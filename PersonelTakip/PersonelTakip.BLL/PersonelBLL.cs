//Deneme
using personelTakip.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip.BLL
{
    public static class PersonelBLL
    {
       
            public static void PersonelEkle(Personeller p)
            {
                if (p == null)
                    throw new Exception("Personel bilgisi boş olamaz.");

                if (string.IsNullOrWhiteSpace(p.Ad))
                    throw new Exception("Ad boş olamaz.");

                if (string.IsNullOrWhiteSpace(p.Soyad))
                    throw new Exception("Soyad boş olamaz.");

                if (string.IsNullOrWhiteSpace(p.KullaniciAdi))
                    throw new Exception("Kullanıcı adı zorunludur.");

                if (string.IsNullOrWhiteSpace(p.Sifre))
                    throw new Exception("Şifre zorunludur.");

                PersonellerDAL.PersonelEkle(p);
            }
        }

    }






