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
    public partial class YöneticiMaasRapor : Form
    {
        public YöneticiMaasRapor()
        {
            InitializeComponent();
        }

        private void YöneticiMaasRapor_Load(object sender, EventArgs e)
        {

            decimal ortalama = MaasBLL.OrtalamaMaasGetir();
            dgvOrtalamaMaas.Text = ortalama.ToString("0.00") + " ₺";

            Ortala();
        }
        void Ortala()
        {
            pnlCenter.Left = (this.ClientSize.Width - pnlCenter.Width) / 2;
            pnlCenter.Top = (this.ClientSize.Height - pnlCenter.Height) / 2;
        }
        private void btnMaasRapor_Click(object sender, EventArgs e)
        {
            
        }
    }
}

