using MySql.Data.MySqlClient;
using personelTakip.DAL;

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
    public partial class IKPerformansEkle : Form
    {
        private Personeller _aktifKullanici;
        public IKPerformansEkle()
        {
            InitializeComponent();
            
        }
     

        private void IKPerformansEkle_Load(object sender, EventArgs e)
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT id, ad FROM Personeller", con);

                MySqlDataReader okunanlar = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(okunanlar);

                personelCmb.DisplayMember = "ad";
                personelCmb.ValueMember = "id";
                personelCmb.DataSource = dt;
            }
            Ortala();
        }
        void Ortala()
        {
            pnlCenter.Left = (this.ClientSize.Width - pnlCenter.Width) / 2;
            pnlCenter.Top = (this.ClientSize.Height - pnlCenter.Height) / 2;
        }
        public IKPerformansEkle(Personeller aktifKullanici)
        {
            InitializeComponent();
            _aktifKullanici = aktifKullanici;

            if (_aktifKullanici.Rol != "İK")
            {
                MessageBox.Show("Yetkiniz yok");
                this.Close();
            }
        }

        private void persKaydetBtn_Click(object sender, EventArgs e)
        {
            Performans p = new Performans
            {
                PersonelId = Convert.ToInt32(personelCmb.SelectedValue),
                Puan = Convert.ToInt32(puanNUD.Value),
                Tarih = DateTime.Now
            };

            PerformansDAL.PerformansEkle(p);

            MessageBox.Show("Performans puanı eklendi");
        }
    }
    }

    



