
using PersonelTakip.BLL;
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
    public partial class DepartmanlarFormu : Form
    {
        private void DepartmanlarFormu_Load(object sender, EventArgs e)
        {
            cmbDepartman.DisplayMember = "departmanAdi";
            cmbDepartman.ValueMember = "id";
            cmbDepartman.DataSource = DepartmanBLL.TumDepartmanlar();
        }
        public DepartmanlarFormu()
        {
            InitializeComponent();
            DepartmanlariYukle();
        }
      
        void DepartmanlariYukle()
        {
            DataTable dt = DepartmanBLL.TumDepartmanlar();

            cmbDepartman.DataSource = dt;
            cmbDepartman.DisplayMember = "ad";  
            cmbDepartman.ValueMember = "id";
        }
        

        private void btnEkle_Click_1(object sender, EventArgs e)
        {

            DepartmanBLL.DepartmanEkle(txtDepartman.Text);
            MessageBox.Show("SQL’e gönderildi");
            DepartmanlariYukle();
           
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbDepartman.SelectedValue);
            DepartmanBLL.DepartmanSil(id);
            DepartmanlariYukle();
        }
        private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartman.SelectedItem == null) return;

            DataRowView drv = cmbDepartman.SelectedItem as DataRowView;
            if (drv == null) return;

            int departmanId = Convert.ToInt32(drv["id"]);

            dgvPersoneller.DataSource =
                DepartmanBLL.DepartmanaGorePersoneller(departmanId);
        }
        

        private void dgvPersoneller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DepartmanlarFormu_Load_1(object sender, EventArgs e)
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

