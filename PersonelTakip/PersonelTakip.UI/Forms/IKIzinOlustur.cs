using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonelTakip.BLL;
using personelTakip.DAL;

namespace PersonelTakip.UI.Forms
{
    public partial class IKIzinOlustur : Form 
    {
        private Personeller _aktifKullanici;

        public IKIzinOlustur(Personeller aktifKullanici)
        {
            InitializeComponent();
            _aktifKullanici = aktifKullanici;

            if (_aktifKullanici.Rol != "İK")
            {
                MessageBox.Show("Bu ekrana erişim yetkiniz yok");
                this.Close();
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir personel seçiniz.");
                return;
            }

            Izin izin = new Izin
            {
                PersonelId = (int)cmbPersonel.SelectedValue,
                BaslangicTarihi = dtpBaslangic.Value,
                BitisTarihi = dtpBitis.Value,
                Aciklama = txtAciklama.Text,
                Durum = "Beklemede"
            };

            try
            {
                IzinBLL.IzinTalepEt(izin);
                MessageBox.Show("İzin talebi başarıyla oluşturuldu.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IKIzinOlustur_Load(object sender, EventArgs e)
        {
            Ortala();
        }
        void Ortala()
        {
            pnlCenter.Left = (this.ClientSize.Width - pnlCenter.Width) / 2;
            pnlCenter.Top = (this.ClientSize.Height - pnlCenter.Height) / 2;
        }
    }
}
