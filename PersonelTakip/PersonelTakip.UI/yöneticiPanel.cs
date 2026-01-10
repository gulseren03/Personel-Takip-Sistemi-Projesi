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
    public partial class yöneticiPanel : Form
    {
        private Personeller _aktifKullanici;
        public yöneticiPanel(Personeller aktifKullanici)
        {
            InitializeComponent();
            _aktifKullanici = aktifKullanici;

            if (_aktifKullanici.Rol != "yönetici")
            {
                MessageBox.Show("Yetkiniz yok");
                this.Close();
            }
        }
        private void yöneticiPanel_Load(object sender, EventArgs e)
        {
            IzinleriGetir();

            Ortala();
           
        }
        void Ortala()
        {
            pnlCenter.Left = (this.ClientSize.Width - pnlCenter.Width) / 2;
            pnlCenter.Top = (this.ClientSize.Height - pnlCenter.Height) / 2;
        }
        private void IzinleriGetir()
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                con.Open();

                string sql = @"SELECT 
                                i.id,
                                i.personelId
                                i.baslangıc,
                                i.bitis,
                                i.acıklama,
                                i.durum
                               FROM izinler i
                               INNER JOIN Personeller p 
                                   ON p.id = i.personelId";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                izinlerDGV.DataSource = dt;
            }
        }
        private void DurumGuncelle(int izinId,string yeniDurum)
        {
            using (MySqlConnection con = Db.GetConnection())
            {
                con.Open();

                string sql = "UPDATE izinler SET durum=@durum WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@durum", yeniDurum);
                cmd.Parameters.AddWithValue("@id", izinId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("İzin durumu güncellendi.");
            IzinleriGetir();
        }
        private void onaylaBtn_Click(object sender, EventArgs e)
        {
            if (izinlerDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir izin seçiniz.");
                return;
            }

            int izinId =
                Convert.ToInt32(izinlerDGV.SelectedRows[0].Cells["id"].Value);

            DurumGuncelle(izinId, "Onaylandı");
        }

        private void reddetBtn_Click(object sender, EventArgs e)
        {
            if (izinlerDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir izin seçiniz.");
                return;
            }

            int izinId = Convert.ToInt32(izinlerDGV.SelectedRows[0].Cells["id"].Value);//cells=hücreler

            DurumGuncelle(izinId, "Reddedildi");
        }

        private void btnMaasRapor_Click(object sender, EventArgs e)
        {
            YöneticiMaasRapor form = new YöneticiMaasRapor();
            form.ShowDialog();
        }

        private void btnMaas_Click(object sender, EventArgs e)
        {
            MaasHesaplama form = new MaasHesaplama();
            form.ShowDialog();
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            DepartmanlarFormu form = new DepartmanlarFormu();
            form.ShowDialog();
        }

        private void btnTümRaporlar_Click(object sender, EventArgs e)
        {
            RaporlarFormu form = new RaporlarFormu();
            form.ShowDialog();
        }
    }
}
