namespace PersonelTakip.UI
{
    partial class PersonelPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.baslangıcDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.bitisDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.izinTalepBtn = new System.Windows.Forms.Button();
            this.panelIzinTalep = new System.Windows.Forms.Panel();
            this.txtAcıklama = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblListe = new System.Windows.Forms.Label();
            this.izinlerDGV = new System.Windows.Forms.DataGridView();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.panelIzinTalep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izinlerDGV)).BeginInit();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // baslangıcDTP
            // 
            this.baslangıcDTP.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslangıcDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.baslangıcDTP.Location = new System.Drawing.Point(366, 26);
            this.baslangıcDTP.Name = "baslangıcDTP";
            this.baslangıcDTP.Size = new System.Drawing.Size(247, 34);
            this.baslangıcDTP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // bitisDTP
            // 
            this.bitisDTP.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitisDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bitisDTP.Location = new System.Drawing.Point(366, 85);
            this.bitisDTP.Name = "bitisDTP";
            this.bitisDTP.Size = new System.Drawing.Size(247, 34);
            this.bitisDTP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(257, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(270, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Açıklama";
            // 
            // izinTalepBtn
            // 
            this.izinTalepBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.izinTalepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izinTalepBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.izinTalepBtn.ForeColor = System.Drawing.Color.Black;
            this.izinTalepBtn.Location = new System.Drawing.Point(690, 196);
            this.izinTalepBtn.Name = "izinTalepBtn";
            this.izinTalepBtn.Size = new System.Drawing.Size(165, 38);
            this.izinTalepBtn.TabIndex = 7;
            this.izinTalepBtn.Text = "İzin Talebi Oluştur";
            this.izinTalepBtn.UseCompatibleTextRendering = true;
            this.izinTalepBtn.UseVisualStyleBackColor = false;
            this.izinTalepBtn.Click += new System.EventHandler(this.btnIzinTalep_Click);
            // 
            // panelIzinTalep
            // 
            this.panelIzinTalep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelIzinTalep.Controls.Add(this.txtAcıklama);
            this.panelIzinTalep.Controls.Add(this.lblBaslik);
            this.panelIzinTalep.Controls.Add(this.baslangıcDTP);
            this.panelIzinTalep.Controls.Add(this.izinTalepBtn);
            this.panelIzinTalep.Controls.Add(this.label1);
            this.panelIzinTalep.Controls.Add(this.label3);
            this.panelIzinTalep.Controls.Add(this.label2);
            this.panelIzinTalep.Controls.Add(this.bitisDTP);
            this.panelIzinTalep.Location = new System.Drawing.Point(3, 3);
            this.panelIzinTalep.Name = "panelIzinTalep";
            this.panelIzinTalep.Size = new System.Drawing.Size(880, 249);
            this.panelIzinTalep.TabIndex = 8;
            // 
            // txtAcıklama
            // 
            this.txtAcıklama.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAcıklama.Location = new System.Drawing.Point(366, 147);
            this.txtAcıklama.Name = "txtAcıklama";
            this.txtAcıklama.Size = new System.Drawing.Size(247, 31);
            this.txtAcıklama.TabIndex = 9;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.OrangeRed;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Black;
            this.lblBaslik.Location = new System.Drawing.Point(3, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(162, 30);
            this.lblBaslik.TabIndex = 8;
            this.lblBaslik.Text = "Yeni İzin Talebi";
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.BackColor = System.Drawing.Color.OrangeRed;
            this.lblListe.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblListe.Location = new System.Drawing.Point(0, 314);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(176, 30);
            this.lblListe.TabIndex = 9;
            this.lblListe.Text = "Önceki İzinlerim";
            // 
            // izinlerDGV
            // 
            this.izinlerDGV.AllowUserToAddRows = false;
            this.izinlerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.izinlerDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.izinlerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izinlerDGV.Location = new System.Drawing.Point(0, 314);
            this.izinlerDGV.Name = "izinlerDGV";
            this.izinlerDGV.ReadOnly = true;
            this.izinlerDGV.RowHeadersVisible = false;
            this.izinlerDGV.RowHeadersWidth = 51;
            this.izinlerDGV.RowTemplate.Height = 24;
            this.izinlerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.izinlerDGV.Size = new System.Drawing.Size(883, 270);
            this.izinlerDGV.TabIndex = 11;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCenter.Controls.Add(this.panelIzinTalep);
            this.pnlCenter.Controls.Add(this.lblListe);
            this.pnlCenter.Controls.Add(this.izinlerDGV);
            this.pnlCenter.Location = new System.Drawing.Point(23, 9);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(886, 610);
            this.pnlCenter.TabIndex = 12;
            // 
            // PersonelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1411, 642);
            this.Controls.Add(this.pnlCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelPanel";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Personel İzin İşlemleri";
            this.Load += new System.EventHandler(this.PersonelPanel_Load);
            this.panelIzinTalep.ResumeLayout(false);
            this.panelIzinTalep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izinlerDGV)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker baslangıcDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker bitisDTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button izinTalepBtn;
        private System.Windows.Forms.Panel panelIzinTalep;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblListe;
        private System.Windows.Forms.DataGridView izinlerDGV;
        private System.Windows.Forms.TextBox txtAcıklama;
        private System.Windows.Forms.Panel pnlCenter;
    }
   

    }