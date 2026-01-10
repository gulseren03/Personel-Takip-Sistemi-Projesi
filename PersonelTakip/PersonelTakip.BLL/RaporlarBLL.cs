using personelTakip.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip.BLL
{
   
        public static class RaporlarBLL
        {
            public static DataTable DepartmanDagilim()
            {
                return RaporlarDAL.DepartmanDagilim();
            }

            public static DataTable IzinRaporu(DateTime bas, DateTime bit)
            {
                return RaporlarDAL.IzinRaporu(bas, bit);
            }

            public static DataTable MaasRaporu()
            {
                return RaporlarDAL.MaasRaporu();
            }

            public static DataTable PerformansRaporu()
            {
                return RaporlarDAL.PerformansRaporu();
            }

            public static DataTable IzinHakEdis()
            {
                return RaporlarDAL.IzinHakEdis();
            }
        }
    }



