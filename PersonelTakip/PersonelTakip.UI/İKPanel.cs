using MySql.Data.MySqlClient;
using personelTakip.DAL;

using PersonelTakip.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PersonelTakip.UI
{
    public partial class İKPanel : Form
    {
        private Personeller _aktifKullanici;

        public İKPanel(Personeller aktifKullanici)
        {
            InitializeComponent();
            _aktifKullanici = aktifKullanici;

            if (_aktifKullanici.Rol != "İK")
            {
                MessageBox.Show("Bu panele erişim yetkiniz yok");
                this.Close();
            }
        }
        private void perfEkleBtn_Click(object sender, EventArgs e)
        {
            IKPerformansEkle form = new IKPerformansEkle();
            form.ShowDialog();
        }

        private void btnİKİzinOlustur_Click(object sender, EventArgs e)
        {
            IKIzinOlustur form = new IKIzinOlustur(_aktifKullanici);
            form.ShowDialog();
        }

        private void btnIzinOlustur_Click(object sender, EventArgs e)
        {
            IKIzinOlustur form = new IKIzinOlustur(_aktifKullanici);
            form.ShowDialog();
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            DepartmanlarFormu form = new DepartmanlarFormu();
            form.ShowDialog();
        }
        void DepartmanlariYukle()
        {
            DataTable liste = DepartmanDAL.TumDepartmanlar();
            MessageBox.Show("Departman sayısı: " + liste.Rows.Count);//rows.count ile listede kaç departman olduğunu gösterir

        }

        private void btnTümRaporlar_Click(object sender, EventArgs e)
        {
            RaporlarFormu form = new RaporlarFormu();
            form.ShowDialog();
        }

       

        private void btnPersonelEkle_Click_1(object sender, EventArgs e)
        {
            PersonelEkleForm frm = new PersonelEkleForm();
            frm.ShowDialog();
        }
    }
}

        
