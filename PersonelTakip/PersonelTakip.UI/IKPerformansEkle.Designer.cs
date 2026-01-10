namespace PersonelTakip.UI
{
    partial class IKPerformansEkle
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
            this.puanNUD = new System.Windows.Forms.NumericUpDown();
            this.personelCmb = new System.Windows.Forms.ComboBox();
            this.persKaydetBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.puanNUD)).BeginInit();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // puanNUD
            // 
            this.puanNUD.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanNUD.Location = new System.Drawing.Point(231, 228);
            this.puanNUD.Name = "puanNUD";
            this.puanNUD.Size = new System.Drawing.Size(230, 39);
            this.puanNUD.TabIndex = 4;
            // 
            // personelCmb
            // 
            this.personelCmb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelCmb.FormattingEnabled = true;
            this.personelCmb.Location = new System.Drawing.Point(231, 124);
            this.personelCmb.Name = "personelCmb";
            this.personelCmb.Size = new System.Drawing.Size(230, 36);
            this.personelCmb.TabIndex = 3;
            // 
            // persKaydetBtn
            // 
            this.persKaydetBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.persKaydetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.persKaydetBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.persKaydetBtn.Location = new System.Drawing.Point(282, 355);
            this.persKaydetBtn.Name = "persKaydetBtn";
            this.persKaydetBtn.Size = new System.Drawing.Size(128, 48);
            this.persKaydetBtn.TabIndex = 2;
            this.persKaydetBtn.Text = "Kaydet";
            this.persKaydetBtn.UseVisualStyleBackColor = false;
            this.persKaydetBtn.Click += new System.EventHandler(this.persKaydetBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(143, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puan :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(112, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "personel :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(180, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "İK Performans Ekle";
            // 
            // pnlCenter
            // 
            this.pnlCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCenter.Controls.Add(this.label5);
            this.pnlCenter.Controls.Add(this.persKaydetBtn);
            this.pnlCenter.Controls.Add(this.label2);
            this.pnlCenter.Controls.Add(this.personelCmb);
            this.pnlCenter.Controls.Add(this.puanNUD);
            this.pnlCenter.Controls.Add(this.label1);
            this.pnlCenter.Location = new System.Drawing.Point(21, -7);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(606, 556);
            this.pnlCenter.TabIndex = 12;
            // 
            // IKPerformansEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(677, 563);
            this.Controls.Add(this.pnlCenter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IKPerformansEkle";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IKPerformansEkle";
            this.Load += new System.EventHandler(this.IKPerformansEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.puanNUD)).EndInit();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown puanNUD;
        private System.Windows.Forms.ComboBox personelCmb;
        private System.Windows.Forms.Button persKaydetBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCenter;
    }
}