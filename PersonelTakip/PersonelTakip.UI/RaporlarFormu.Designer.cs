namespace PersonelTakip.UI
{
    partial class RaporlarFormu
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
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDepartman = new System.Windows.Forms.Button();
            this.btnİzin = new System.Windows.Forms.Button();
            this.btnMaas = new System.Windows.Forms.Button();
            this.btnPerformans = new System.Windows.Forms.Button();
            this.btnİzinHakedis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlCenter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRapor
            // 
            this.dgvRapor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor.Location = new System.Drawing.Point(6, 411);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.RowHeadersWidth = 51;
            this.dgvRapor.RowTemplate.Height = 24;
            this.dgvRapor.Size = new System.Drawing.Size(834, 230);
            this.dgvRapor.TabIndex = 0;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBaslangic.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dtpBaslangic.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpBaslangic.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBaslangic.Location = new System.Drawing.Point(102, 22);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(241, 34);
            this.dtpBaslangic.TabIndex = 1;
            // 
            // dtpBitis
            // 
            this.dtpBitis.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBitis.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpBitis.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBitis.Location = new System.Drawing.Point(528, 19);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(231, 34);
            this.dtpBitis.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Başlangıç";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(423, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDepartman
            // 
            this.btnDepartman.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDepartman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartman.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartman.ForeColor = System.Drawing.Color.Black;
            this.btnDepartman.Location = new System.Drawing.Point(701, 360);
            this.btnDepartman.Name = "btnDepartman";
            this.btnDepartman.Size = new System.Drawing.Size(126, 45);
            this.btnDepartman.TabIndex = 7;
            this.btnDepartman.Text = "Departman Raporu";
            this.btnDepartman.UseCompatibleTextRendering = true;
            this.btnDepartman.UseVisualStyleBackColor = false;
            this.btnDepartman.Click += new System.EventHandler(this.btnDepartman_Click);
            // 
            // btnİzin
            // 
            this.btnİzin.BackColor = System.Drawing.Color.OrangeRed;
            this.btnİzin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİzin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİzin.ForeColor = System.Drawing.Color.Black;
            this.btnİzin.Location = new System.Drawing.Point(179, 360);
            this.btnİzin.Name = "btnİzin";
            this.btnİzin.Size = new System.Drawing.Size(126, 45);
            this.btnİzin.TabIndex = 6;
            this.btnİzin.Text = "İzin Raporu";
            this.btnİzin.UseCompatibleTextRendering = true;
            this.btnİzin.UseVisualStyleBackColor = false;
            this.btnİzin.Click += new System.EventHandler(this.btnİzin_Click);
            // 
            // btnMaas
            // 
            this.btnMaas.BackColor = System.Drawing.Color.OrangeRed;
            this.btnMaas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaas.ForeColor = System.Drawing.Color.Black;
            this.btnMaas.Location = new System.Drawing.Point(15, 360);
            this.btnMaas.Name = "btnMaas";
            this.btnMaas.Size = new System.Drawing.Size(126, 45);
            this.btnMaas.TabIndex = 7;
            this.btnMaas.Text = "Maaş Raporu";
            this.btnMaas.UseCompatibleTextRendering = true;
            this.btnMaas.UseVisualStyleBackColor = false;
            this.btnMaas.Click += new System.EventHandler(this.btnMaas_Click);
            // 
            // btnPerformans
            // 
            this.btnPerformans.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPerformans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPerformans.ForeColor = System.Drawing.Color.Black;
            this.btnPerformans.Location = new System.Drawing.Point(352, 360);
            this.btnPerformans.Name = "btnPerformans";
            this.btnPerformans.Size = new System.Drawing.Size(126, 45);
            this.btnPerformans.TabIndex = 8;
            this.btnPerformans.Text = "Performans Raporu";
            this.btnPerformans.UseCompatibleTextRendering = true;
            this.btnPerformans.UseVisualStyleBackColor = false;
            this.btnPerformans.Click += new System.EventHandler(this.btnPerformans_Click);
            // 
            // btnİzinHakedis
            // 
            this.btnİzinHakedis.BackColor = System.Drawing.Color.OrangeRed;
            this.btnİzinHakedis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİzinHakedis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİzinHakedis.ForeColor = System.Drawing.Color.Black;
            this.btnİzinHakedis.Location = new System.Drawing.Point(531, 360);
            this.btnİzinHakedis.Name = "btnİzinHakedis";
            this.btnİzinHakedis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnİzinHakedis.Size = new System.Drawing.Size(126, 45);
            this.btnİzinHakedis.TabIndex = 7;
            this.btnİzinHakedis.Text = "İzin Hakediş Raporu";
            this.btnİzinHakedis.UseCompatibleTextRendering = true;
            this.btnİzinHakedis.UseVisualStyleBackColor = false;
            this.btnİzinHakedis.Click += new System.EventHandler(this.btnİzinHakedis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 48);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(283, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 51);
            this.label3.TabIndex = 4;
            this.label3.Text = "Raporlar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpBaslangic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpBitis);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 66);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarih Aralığı";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCenter.Controls.Add(this.panel1);
            this.pnlCenter.Controls.Add(this.btnDepartman);
            this.pnlCenter.Controls.Add(this.btnİzinHakedis);
            this.pnlCenter.Controls.Add(this.groupBox1);
            this.pnlCenter.Controls.Add(this.btnİzin);
            this.pnlCenter.Controls.Add(this.btnPerformans);
            this.pnlCenter.Controls.Add(this.dgvRapor);
            this.pnlCenter.Controls.Add(this.btnMaas);
            this.pnlCenter.Location = new System.Drawing.Point(51, 4);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(840, 656);
            this.pnlCenter.TabIndex = 12;
            // 
            // RaporlarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1435, 689);
            this.Controls.Add(this.pnlCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RaporlarFormu";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RaporlarFormu";
            this.Load += new System.EventHandler(this.RaporlarFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRapor;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDepartman;
        private System.Windows.Forms.Button btnİzin;
        private System.Windows.Forms.Button btnMaas;
        private System.Windows.Forms.Button btnPerformans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnİzinHakedis;
        private System.Windows.Forms.Panel pnlCenter;
    }
}