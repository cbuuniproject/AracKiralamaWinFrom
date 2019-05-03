namespace AracKiralamaSistemi
{
    partial class frm_SirketEkle
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
            this.tpSirketEkle = new System.Windows.Forms.TabPage();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPersonelKaydet = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSirketAdi = new System.Windows.Forms.TextBox();
            this.txtSirketSehir = new System.Windows.Forms.TextBox();
            this.txtSirketAdres = new System.Windows.Forms.TextBox();
            this.btnSirketKaydet = new System.Windows.Forms.Button();
            this.tcSirketEkle.SuspendLayout();
            this.tpPersonelEkle.SuspendLayout();
            this.tpSirketEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSirketEkle
            // 
            this.tcSirketEkle.Controls.Add(this.tpPersonelEkle);
            this.tcSirketEkle.Controls.Add(this.tpSirketEkle);
            this.tcSirketEkle.Location = new System.Drawing.Point(12, 12);
            this.tcSirketEkle.Name = "tcSirketEkle";
            this.tcSirketEkle.SelectedIndex = 0;
            this.tcSirketEkle.Size = new System.Drawing.Size(776, 426);
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
            this.tpPersonelEkle.Controls.Add(this.txtModel);
            this.tpPersonelEkle.Controls.Add(this.txtMarka);
            this.tpPersonelEkle.Controls.Add(this.label2);
            this.tpPersonelEkle.Controls.Add(this.label1);
            this.tpPersonelEkle.Location = new System.Drawing.Point(4, 22);
            this.tpPersonelEkle.Name = "tpPersonelEkle";
            this.tpPersonelEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonelEkle.Size = new System.Drawing.Size(768, 400);
            this.tpPersonelEkle.TabIndex = 0;
            this.tpPersonelEkle.Text = "Şirket Personeli Ekle";
            this.tpPersonelEkle.UseVisualStyleBackColor = true;
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
            this.tpSirketEkle.Location = new System.Drawing.Point(4, 22);
            this.tpSirketEkle.Name = "tpSirketEkle";
            this.tpSirketEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tpSirketEkle.Size = new System.Drawing.Size(768, 400);
            this.tpSirketEkle.TabIndex = 1;
            this.tpSirketEkle.Text = "Şirket Ekle";
            this.tpSirketEkle.UseVisualStyleBackColor = true;
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(381, 200);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(193, 20);
            this.txtKullaniciSifre.TabIndex = 51;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(381, 174);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(193, 20);
            this.txtKullaniciAdi.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Kullanici Adi";
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.Location = new System.Drawing.Point(454, 241);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(120, 37);
            this.btnPersonelKaydet.TabIndex = 47;
            this.btnPersonelKaydet.Text = "Kaydet";
            this.btnPersonelKaydet.UseVisualStyleBackColor = true;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(381, 148);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(193, 20);
            this.txtModel.TabIndex = 46;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(381, 122);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(193, 20);
            this.txtMarka.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şirket Adi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Şehir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adres";
            // 
            // txtSirketAdi
            // 
            this.txtSirketAdi.Location = new System.Drawing.Point(357, 109);
            this.txtSirketAdi.Name = "txtSirketAdi";
            this.txtSirketAdi.Size = new System.Drawing.Size(222, 20);
            this.txtSirketAdi.TabIndex = 3;
            // 
            // txtSirketSehir
            // 
            this.txtSirketSehir.Location = new System.Drawing.Point(357, 135);
            this.txtSirketSehir.Name = "txtSirketSehir";
            this.txtSirketSehir.Size = new System.Drawing.Size(222, 20);
            this.txtSirketSehir.TabIndex = 4;
            // 
            // txtSirketAdres
            // 
            this.txtSirketAdres.Location = new System.Drawing.Point(357, 161);
            this.txtSirketAdres.Name = "txtSirketAdres";
            this.txtSirketAdres.Size = new System.Drawing.Size(222, 20);
            this.txtSirketAdres.TabIndex = 5;
            // 
            // btnSirketKaydet
            // 
            this.btnSirketKaydet.Location = new System.Drawing.Point(448, 205);
            this.btnSirketKaydet.Name = "btnSirketKaydet";
            this.btnSirketKaydet.Size = new System.Drawing.Size(131, 73);
            this.btnSirketKaydet.TabIndex = 6;
            this.btnSirketKaydet.Text = "Kaydet";
            this.btnSirketKaydet.UseVisualStyleBackColor = true;
            // 
            // frm_SirketEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcSirketEkle);
            this.Name = "frm_SirketEkle";
            this.Text = "frm_SirketEkle";
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
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
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