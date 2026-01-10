

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
    public partial class MaasHesaplama : Form
    {
        public MaasHesaplama()
        {
            InitializeComponent();
            PersonelleriYukle();
        }
        void PersonelleriYukle()
        {
            cmbPersonel.DataSource = PersonellerDAL.TumPersoneller();
            cmbPersonel.DisplayMember = "ad";
            cmbPersonel.ValueMember = "id";
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHesapla_Click_1(object sender, EventArgs e)
        {
            decimal brut = Convert.ToDecimal(txtBrut.Text);
            decimal primYuzde = Convert.ToDecimal(txtPrim.Text);
            decimal kesintiYuzde = Convert.ToDecimal(txtKesinti.Text);

            decimal net = MaasBLL.NetMaasHesapla(brut, primYuzde, kesintiYuzde);
            lblNet.Text = net.ToString("0.00");//Net maaşı iki ondalık basamakla gösterir
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            int personelId = (int)cmbPersonel.SelectedValue;

            decimal brut = Convert.ToDecimal(txtBrut.Text);
            decimal prim = Convert.ToDecimal(txtPrim.Text);
            decimal kesinti = Convert.ToDecimal(txtKesinti.Text);


            MaasBLL.MaasKaydet(personelId, brut, prim, kesinti);

            MessageBox.Show("Maaş başarıyla kaydedildi.");
       
        }

        private void MaasHesaplama_Load(object sender, EventArgs e)
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
    

