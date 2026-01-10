using personelTakip.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PersonelTakip.BLL
{
    public static class DepartmanBLL
    {
        public static void DepartmanEkle(string departmanAdi)
        {
            if (string.IsNullOrWhiteSpace(departmanAdi))
                throw new Exception("Departman adı boş olamaz.");

            DepartmanDAL.DepartmanEkle(departmanAdi);
        }


        public static void DepartmanSil(int id)
        {
            if (id <= 0)
                throw new Exception("Geçersiz departman.");

            DepartmanDAL.DepartmanSil(id);
        }
        public static DataTable TumDepartmanlar()
        {
            return DepartmanDAL.TumDepartmanlar();
        }

        public static DataTable DepartmanaGorePersoneller(int departmanId)
        {
            if (departmanId <= 0)
                throw new Exception("Departman seçilmedi.");

            return PersonellerDAL.DepartmanaGorePersoneller(departmanId);
        }
    }
}
        
    



    
