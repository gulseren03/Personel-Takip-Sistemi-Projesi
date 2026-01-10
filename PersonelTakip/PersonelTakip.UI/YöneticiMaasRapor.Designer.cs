namespace PersonelTakip.UI
{
    partial class YöneticiMaasRapor
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
            this.dgvMaaslar = new System.Windows.Forms.DataGridView();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.dgvOrtalamaMaas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaaslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrtalamaMaas)).BeginInit();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaaslar
            // 
            this.dgvMaaslar.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvMaaslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaaslar.Location = new System.Drawing.Point(160, 123);
            this.dgvMaaslar.Name = "dgvMaaslar";
            this.dgvMaaslar.RowHeadersWidth = 51;
            this.dgvMaaslar.RowTemplate.Height = 24;
            this.dgvMaaslar.Size = new System.Drawing.Size(642, 80);
            this.dgvMaaslar.TabIndex = 2;
            // 
            // lblToplam
            // 
            this.lblToplam.BackColor = System.Drawing.Color.OrangeRed;
            this.lblToplam.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.ForeColor = System.Drawing.Color.Black;
            this.lblToplam.Location = new System.Drawing.Point(28, 123);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(116, 80);
            this.lblToplam.TabIndex = 3;
            this.lblToplam.Text = "Ortalama Maaş";
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrtalama.BackColor = System.Drawing.Color.OrangeRed;
            this.lblOrtalama.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalama.ForeColor = System.Drawing.Color.Black;
            this.lblOrtalama.Location = new System.Drawing.Point(26, 272);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(118, 80);
            this.lblOrtalama.TabIndex = 4;
            this.lblOrtalama.Text = "Toplam Maaş";
            this.lblOrtalama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOrtalamaMaas
            // 
            this.dgvOrtalamaMaas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvOrtalamaMaas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrtalamaMaas.Location = new System.Drawing.Point(160, 272);
            this.dgvOrtalamaMaas.Name = "dgvOrtalamaMaas";
            this.dgvOrtalamaMaas.RowHeadersWidth = 51;
            this.dgvOrtalamaMaas.RowTemplate.Height = 24;
            this.dgvOrtalamaMaas.Size = new System.Drawing.Size(642, 80);
            this.dgvOrtalamaMaas.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(249, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = " Yönetici Maaş Raporları";
            // 
            // pnlCenter
            // 
            this.pnlCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCenter.Controls.Add(this.dgvMaaslar);
            this.pnlCenter.Controls.Add(this.label5);
            this.pnlCenter.Controls.Add(this.dgvOrtalamaMaas);
            this.pnlCenter.Controls.Add(this.lblOrtalama);
            this.pnlCenter.Controls.Add(this.lblToplam);
            this.pnlCenter.Location = new System.Drawing.Point(23, 8);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(838, 521);
            this.pnlCenter.TabIndex = 12;
            // 
            // YöneticiMaasRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(984, 616);
            this.Controls.Add(this.pnlCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YöneticiMaasRapor";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "YöneticiMaasRapor";
            this.Load += new System.EventHandler(this.YöneticiMaasRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaaslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrtalamaMaas)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaaslar;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.DataGridView dgvOrtalamaMaas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCenter;
    }
}