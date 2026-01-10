using personelTakip.DAL;
using PersonelTakip.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip.UI
{
    public partial class FrmAnaPanel : Form
    {

        private Personeller _aktifKullanici;

        public FrmAnaPanel(Personeller aktifKullanici)
        {
            InitializeComponent();

            _aktifKullanici = aktifKullanici;
        }
        private void FrmAnaPanel_Load(object sender, EventArgs e)
        {
            TumButonlariKapat();

            switch (_aktifKullanici.Rol)
            {
                case "personel":
                    btnIzin.Visible = true;
                    break;

                case "İK":
                    btnPersonel.Visible = true;
                    btnDepartman.Visible = true;
                    btnIzin.Visible = true;
                    btnMaas.Visible = true;
                    btnPerformans.Visible = true;
                    btnRapor.Visible = true;
                    break;

                case "yönetici":
                    btnMaas.Visible = true;
                    btnRapor.Visible = true;
                    break;

                default:
                    MessageBox.Show("Yetkisiz giriş");
                    this.Close();
                    break;
            }
        }
        private void TumButonlariKapat()
        {
            btnPersonel.Visible = false;
            btnDepartman.Visible = false;
            btnIzin.Visible = false;
            btnMaas.Visible = false;
            btnPerformans.Visible = false;
            btnRapor.Visible = false;
        }
        private void btnIzin_Click(object sender, EventArgs e)
        {
          
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDepartman_Click(object sender, EventArgs e)
        {
          
        }

        private void btnPerformans_Click(object sender, EventArgs e)
        {
          
        }

        private void btnMaas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            
        }


        private void btnIzin_Click_1(object sender, EventArgs e)
        {
            if (_aktifKullanici.Rol == "personel")
                FormuPaneldeAc(new PersonelPanel(_aktifKullanici));
            else
                FormuPaneldeAc(new IKIzinOlustur(_aktifKullanici));
        }
           
              

        private void btnPersonel_Click_1(object sender, EventArgs e)
        {
            if (_aktifKullanici.Rol != "İK") return;
            FormuPaneldeAc(new PersonelEkleForm());
        }

        private void btnDepartman_Click_1(object sender, EventArgs e)
        {
            if (_aktifKullanici.Rol != "İK") return;
            FormuPaneldeAc(new DepartmanlarFormu());
        }

        private void btnPerformans_Click_1(object sender, EventArgs e)
        {
            if (_aktifKullanici.Rol != "İK") return;
            FormuPaneldeAc(new IKPerformansEkle(_aktifKullanici));
        }

        private void btnMaas_Click_1(object sender, EventArgs e)
        {
            if (_aktifKullanici.Rol == "İK" || _aktifKullanici.Rol == "yönetici")
                FormuPaneldeAc(new MaasHesaplama());
        }

        private void btnRapor_Click_1(object sender, EventArgs e)
        {
            if (_aktifKullanici.Rol == "İK" || _aktifKullanici.Rol == "yönetici")
                FormuPaneldeAc(new RaporlarFormu());
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
         void FormuPaneldeAc(Form frm)
        {
            pnlContent.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(frm);
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}




