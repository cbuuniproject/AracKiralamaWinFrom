namespace AracKiralamaSistemi
{
    partial class frm_PersonelEkle
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
			this.btnKaydet = new System.Windows.Forms.Button();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
			this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnKaydet
			// 
			this.btnKaydet.Location = new System.Drawing.Point(479, 180);
			this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(160, 46);
			this.btnKaydet.TabIndex = 38;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = true;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(381, 65);
			this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(256, 22);
			this.txtSoyad.TabIndex = 30;
			this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(381, 33);
			this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(256, 22);
			this.txtAd.TabIndex = 29;
			this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(133, 69);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 21;
			this.label2.Text = "Soyad";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(133, 37);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 17);
			this.label1.TabIndex = 20;
			this.label1.Text = "Ad";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtKullaniciSifre
			// 
			this.txtKullaniciSifre.Location = new System.Drawing.Point(381, 129);
			this.txtKullaniciSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtKullaniciSifre.Name = "txtKullaniciSifre";
			this.txtKullaniciSifre.Size = new System.Drawing.Size(256, 22);
			this.txtKullaniciSifre.TabIndex = 42;
			this.txtKullaniciSifre.TextChanged += new System.EventHandler(this.txtKullaniciSifre_TextChanged);
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Location = new System.Drawing.Point(381, 97);
			this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(256, 22);
			this.txtKullaniciAdi.TabIndex = 41;
			this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(133, 133);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 17);
			this.label3.TabIndex = 40;
			this.label3.Text = "Şifre";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(133, 101);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 17);
			this.label4.TabIndex = 39;
			this.label4.Text = "Kullanici Adi";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// frm_PersonelEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(777, 263);
			this.Controls.Add(this.txtKullaniciSifre);
			this.Controls.Add(this.txtKullaniciAdi);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frm_PersonelEkle";
			this.Text = "Personel Ekle";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}