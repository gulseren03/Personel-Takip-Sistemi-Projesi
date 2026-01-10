
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
    public partial class RaporlarFormu : Form
    {
        public RaporlarFormu()
        {
            InitializeComponent();
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
            dgvRapor.DataSource = RaporlarBLL.DepartmanDagilim();//datasource, dgvRapor'a departman dağılımını atar
        }

        private void btnİzin_Click(object sender, EventArgs e)
        {
            dgvRapor.DataSource = null;
            dgvRapor.DataSource =
            RaporlarBLL.IzinRaporu(dtpBaslangic.Value, dtpBitis.Value);
        }

        private void btnMaas_Click(object sender, EventArgs e)
        {
            dgvRapor.DataSource = RaporlarBLL.MaasRaporu();
        }

        private void btnPerformans_Click(object sender, EventArgs e)
        {
            dgvRapor.DataSource = RaporlarBLL.PerformansRaporu();
        }

        private void btnİzinHakedis_Click(object sender, EventArgs e)
        {
            dgvRapor.DataSource = RaporlarBLL.IzinHakEdis();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RaporlarFormu_Load(object sender, EventArgs e)
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
