using AracKiralamaSistemi.CalisanService;
using AracKiralamaSistemi.KullaniciService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaSistemi
{
    public partial class frm_PersonelEkle : Form
    {
        public frm_PersonelEkle()
        {
            InitializeComponent();
        }

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			int kullaniciId;
			KullaniciService.Kullanici kullanici = new KullaniciService.Kullanici()
			{
				kullaniciAd = txtKullaniciAdi.Text,
				kullaniciTuru = "yetkili",
				parola = txtKullaniciSifre.Text
			};
			using (var kullaniciSoapClient = new KullaniciWebServiceSoapClient())
			{
				kullaniciSoapClient.InsertKullanici(kullanici);
				kullaniciId = kullaniciSoapClient.MaxKullaniciId();
			}
			Calisan calisan = new Calisan()
			{
				ad = txtAd.Text,
				soyad = txtSoyad.Text,
				sirketId = 5
			};
			using (var calisanSoapClient = new CalisanWebServiceSoapClient())
			{
				if (calisanSoapClient.InsertCalisan(calisan))
				{
					MessageBox.Show("Personel Başarıyla Eklendi");
					txtSoyad.Text = "";
					txtAd.Text = "";
					txtKullaniciAdi.Text = "";
					txtKullaniciSifre.Text = "";
				}
				else
					MessageBox.Show("Kayıt Yapılırken bir hata oluştu!");
			}
		}

		private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void txtKullaniciSifre_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtSoyad_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtAd_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
