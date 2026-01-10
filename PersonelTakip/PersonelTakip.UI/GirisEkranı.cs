using MySql.Data.MySqlClient;
using personelTakip.DAL;
using PersonelTakip.BLL;
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
    public partial class GirisEkranı : Form
    {


        public GirisEkranı()
        {
            InitializeComponent();

        }

        private void girisYapBtn_Click(object sender, EventArgs e)
        {
            GirisBLL bll = new GirisBLL();
            Personeller aktifKullanici =
                bll.GirisYap(txtKullaniciAdi.Text, txtSifre.Text);

            if (aktifKullanici == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                return;
            }

            FrmAnaPanel frm = new FrmAnaPanel(aktifKullanici);
            frm.Show();
            this.Hide();
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


        





