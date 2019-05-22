namespace AracKiralamaSistemi
{
    partial class frm_Secim
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
			this.tcSirketEkle = new System.Windows.Forms.TabControl();
			this.tpPersonelEkle = new System.Windows.Forms.TabPage();
			this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
			this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnPersonelKaydet = new System.Windows.Forms.Button();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tpSirketEkle = new System.Windows.Forms.TabPage();
			this.btnSirketKaydet = new System.Windows.Forms.Button();
			this.txtSirketAdres = new System.Windows.Forms.TextBox();
			this.txtSirketSehir = new System.Windows.Forms.TextBox();
			this.txtSirketAdi = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tcSirketEkle.SuspendLayout();
			this.tpPersonelEkle.SuspendLayout();
			this.tpSirketEkle.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcSirketEkle
			// 
			this.tcSirketEkle.Controls.Add(this.tpPersonelEkle);
			this.tcSirketEkle.Controls.Add(this.tpSirketEkle);
			this.tcSirketEkle.Location = new System.Drawing.Point(19, 17);
			this.tcSirketEkle.Margin = new System.Windows.Forms.Padding(4);
			this.tcSirketEkle.Name = "tcSirketEkle";
			this.tcSirketEkle.SelectedIndex = 0;
			this.tcSirketEkle.Size = new System.Drawing.Size(1035, 524);
			this.tcSirketEkle.TabIndex = 0;
			this.tcSirketEkle.TabStop = false;
			// 
			// tpPersonelEkle
			// 
			this.tpPersonelEkle.Controls.Add(this.txtKullaniciSifre);
			this.tpPersonelEkle.Controls.Add(this.txtKullaniciAdi);
			this.tpPersonelEkle.Controls.Add(this.label3);
			this.tpPersonelEkle.Controls.Add(this.label4);
			this.tpPersonelEkle.Controls.Add(this.btnPersonelKaydet);
			this.tpPersonelEkle.Controls.Add(this.txtSoyad);
			this.tpPersonelEkle.Controls.Add(this.txtAd);
			this.tpPersonelEkle.Controls.Add(this.label2);
			this.tpPersonelEkle.Controls.Add(this.label1);
			this.tpPersonelEkle.Location = new System.Drawing.Point(4, 25);
			this.tpPersonelEkle.Margin = new System.Windows.Forms.Padding(4);
			this.tpPersonelEkle.Name = "tpPersonelEkle";
			this.tpPersonelEkle.Padding = new System.Windows.Forms.Padding(4);
			this.tpPersonelEkle.Size = new System.Drawing.Size(1027, 495);
			this.tpPersonelEkle.TabIndex = 0;
			this.tpPersonelEkle.Text = "Şirket Personeli Ekle";
			this.tpPersonelEkle.UseVisualStyleBackColor = true;
			// 
			// txtKullaniciSifre
			// 
			this.txtKullaniciSifre.Location = new System.Drawing.Point(508, 246);
			this.txtKullaniciSifre.Margin = new System.Windows.Forms.Padding(4);
			this.txtKullaniciSifre.Name = "txtKullaniciSifre";
			this.txtKullaniciSifre.Size = new System.Drawing.Size(256, 22);
			this.txtKullaniciSifre.TabIndex = 51;
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Location = new System.Drawing.Point(508, 214);
			this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(256, 22);
			this.txtKullaniciAdi.TabIndex = 50;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(260, 250);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 17);
			this.label3.TabIndex = 49;
			this.label3.Text = "Şifre";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(260, 218);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 17);
			this.label4.TabIndex = 48;
			this.label4.Text = "Kullanici Adi";
			// 
			// btnPersonelKaydet
			// 
			this.btnPersonelKaydet.Location = new System.Drawing.Point(605, 297);
			this.btnPersonelKaydet.Margin = new System.Windows.Forms.Padding(4);
			this.btnPersonelKaydet.Name = "btnPersonelKaydet";
			this.btnPersonelKaydet.Size = new System.Drawing.Size(160, 46);
			this.btnPersonelKaydet.TabIndex = 47;
			this.btnPersonelKaydet.Text = "Kaydet";
			this.btnPersonelKaydet.UseVisualStyleBackColor = true;
			this.btnPersonelKaydet.Click += new System.EventHandler(this.btnPersonelKaydet_Click);
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(508, 182);
			this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(256, 22);
			this.txtSoyad.TabIndex = 46;
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(508, 150);
			this.txtAd.Margin = new System.Windows.Forms.Padding(4);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(256, 22);
			this.txtAd.TabIndex = 45;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(260, 186);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 44;
			this.label2.Text = "Soyad";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(260, 154);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 17);
			this.label1.TabIndex = 43;
			this.label1.Text = "Ad";
			// 
			// tpSirketEkle
			// 
			this.tpSirketEkle.Controls.Add(this.btnSirketKaydet);
			this.tpSirketEkle.Controls.Add(this.txtSirketAdres);
			this.tpSirketEkle.Controls.Add(this.txtSirketSehir);
			this.tpSirketEkle.Controls.Add(this.txtSirketAdi);
			this.tpSirketEkle.Controls.Add(this.label7);
			this.tpSirketEkle.Controls.Add(this.label6);
			this.tpSirketEkle.Controls.Add(this.label5);
			this.tpSirketEkle.Location = new System.Drawing.Point(4, 25);
			this.tpSirketEkle.Margin = new System.Windows.Forms.Padding(4);
			this.tpSirketEkle.Name = "tpSirketEkle";
			this.tpSirketEkle.Padding = new System.Windows.Forms.Padding(4);
			this.tpSirketEkle.Size = new System.Drawing.Size(1027, 495);
			this.tpSirketEkle.TabIndex = 1;
			this.tpSirketEkle.Text = "Şirket Ekle";
			this.tpSirketEkle.UseVisualStyleBackColor = true;
			// 
			// btnSirketKaydet
			// 
			this.btnSirketKaydet.Location = new System.Drawing.Point(537, 355);
			this.btnSirketKaydet.Margin = new System.Windows.Forms.Padding(4);
			this.btnSirketKaydet.Name = "btnSirketKaydet";
			this.btnSirketKaydet.Size = new System.Drawing.Size(175, 90);
			this.btnSirketKaydet.TabIndex = 6;
			this.btnSirketKaydet.Text = "Kaydet";
			this.btnSirketKaydet.UseVisualStyleBackColor = true;
			this.btnSirketKaydet.Click += new System.EventHandler(this.btnSirketKaydet_Click);
			// 
			// txtSirketAdres
			// 
			this.txtSirketAdres.Location = new System.Drawing.Point(476, 198);
			this.txtSirketAdres.Margin = new System.Windows.Forms.Padding(4);
			this.txtSirketAdres.Name = "txtSirketAdres";
			this.txtSirketAdres.Size = new System.Drawing.Size(295, 22);
			this.txtSirketAdres.TabIndex = 5;
			// 
			// txtSirketSehir
			// 
			this.txtSirketSehir.Location = new System.Drawing.Point(476, 166);
			this.txtSirketSehir.Margin = new System.Windows.Forms.Padding(4);
			this.txtSirketSehir.Name = "txtSirketSehir";
			this.txtSirketSehir.Size = new System.Drawing.Size(295, 22);
			this.txtSirketSehir.TabIndex = 4;
			// 
			// txtSirketAdi
			// 
			this.txtSirketAdi.Location = new System.Drawing.Point(476, 134);
			this.txtSirketAdi.Margin = new System.Windows.Forms.Padding(4);
			this.txtSirketAdi.Name = "txtSirketAdi";
			this.txtSirketAdi.Size = new System.Drawing.Size(295, 22);
			this.txtSirketAdi.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(280, 202);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 17);
			this.label7.TabIndex = 2;
			this.label7.Text = "Adres";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(280, 170);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "Şehir";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(280, 138);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Şirket Adi";
			// 
			// frm_SirketEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.tcSirketEkle);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frm_SirketEkle";
			this.Text = "Şirket veya Personel Ekle";
			this.tcSirketEkle.ResumeLayout(false);
			this.tpPersonelEkle.ResumeLayout(false);
			this.tpPersonelEkle.PerformLayout();
			this.tpSirketEkle.ResumeLayout(false);
			this.tpSirketEkle.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSirketEkle;
        private System.Windows.Forms.TabPage tpPersonelEkle;
        private System.Windows.Forms.TabPage tpSirketEkle;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPersonelKaydet;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSirketKaydet;
        private System.Windows.Forms.TextBox txtSirketAdres;
        private System.Windows.Forms.TextBox txtSirketSehir;
        private System.Windows.Forms.TextBox txtSirketAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}