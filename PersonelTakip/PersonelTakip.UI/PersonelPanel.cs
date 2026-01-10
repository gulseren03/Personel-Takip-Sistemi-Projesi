using MySql.Data.MySqlClient;
using personelTakip.DAL;
using PersonelTakip.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PersonelTakip.UI
{
    public partial class PersonelPanel : Form
    {
        private Personeller _aktifKullanici;
        private int _personelId;

        public PersonelPanel(Personeller aktifKullanici)
        {
            InitializeComponent();

            _aktifKullanici = aktifKullanici;
            _personelId = aktifKullanici.Id;

            if (_aktifKullanici.Rol != "personel")
            {
                MessageBox.Show("Bu panele erişim yetkiniz yok.");
                this.Close();
            }
        }

        private void PersonelPanel_Load(object sender, EventArgs e)
        {
            
            IzinleriGetir();

            Ortala();
        }
        void Ortala()
        {
            pnlCenter.Left = (this.ClientSize.Width - pnlCenter.Width) / 2;
            pnlCenter.Top = (this.ClientSize.Height - pnlCenter.Height) / 2;
        }

        private void btnIzinTalep_Click(object sender, EventArgs e)
        {
            try
            {
                Izin izin = new Izin
                {
                    PersonelId = _personelId,
                    BaslangicTarihi = baslangıcDTP.Value,
                    BitisTarihi = bitisDTP.Value,
                    Aciklama = txtAcıklama.Text,
                    Durum = "Beklemede"
                };

                IzinBLL.IzinTalepEt(izin);

                MessageBox.Show("İzin talebi başarıyla oluşturuldu.");
                IzinleriGetir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
             private void IzinleriGetir()
        {
           

            using (MySqlConnection con = Db.GetConnection())
            {
                con.Open();

                string sql = @"SELECT baslangıc, bitis, acıklama, durum
                               FROM izinler
                               WHERE personelId = @pid";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                da.SelectCommand.Parameters.AddWithValue("@pid", _aktifKullanici.Id);

                DataTable dt = new DataTable();
                da.Fill(dt);

                izinlerDGV.AutoGenerateColumns = true;
                izinlerDGV.DataSource = dt;
            }
        }
    }
}
    


    




          






