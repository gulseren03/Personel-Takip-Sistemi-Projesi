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
    public partial class PersonelEkleForm : Form
    {
        public PersonelEkleForm()
        {
            InitializeComponent();
        }

        private void PersonelEkleForm_Load(object sender, EventArgs e)
        {
            cmbRol.Items.Add("yönetici");
            cmbRol.Items.Add("İK");
            cmbRol.Items.Add("personel");
            cmbRol.SelectedIndex = 2;

            cmbDepartman.DataSource = DepartmanDAL.TumDepartmanlar();
            cmbDepartman.DisplayMember = "departmanAdi";
            cmbDepartman.ValueMember = "id";

            Ortala();
        }
        void Ortala()
        {
            pnlCenter.Left = (this.ClientSize.Width - pnlCenter.Width) / 2;
            pnlCenter.Top = (this.ClientSize.Height - pnlCenter.Height) / 2;
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Personeller p = new Personeller
                {
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    KullaniciAdi = txtKullaniciAdi.Text.Trim(),
                    Sifre = txtSifre.Text,
                    Rol = cmbRol.Text,
                    DepartmanId = (int)cmbDepartman.SelectedValue,
                    IseGirisTarihi = DateTime.Today
                };

                PersonelBLL.PersonelEkle(p);

                MessageBox.Show("Personel başarıyla eklendi.");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

