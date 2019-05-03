using AracKiralamaSistemi.CalisanService;
using AracKiralamaSistemi.KullaniciService;
using AracKiralamaSistemi.SirketService;
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
	public partial class frm_SirketEkle : Form
	{
		public frm_SirketEkle()
		{
			InitializeComponent();
		}

		private void btnPersonelKaydet_Click(object sender, EventArgs e)
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

		private void btnSirketKaydet_Click(object sender, EventArgs e)
		{
			SirketService.Sirket sirket = new SirketService.Sirket()
			{
				sehir = txtSirketSehir.Text,
				adres = txtSirketAdres.Text,
				sirketAdi=txtSirketAdi.Text,
				sirketPuani=0
			};
			using (var sirketSoapClient = new SirketWebServiceSoapClient())
			{
				sirketSoapClient.InsertSirket(sirket);
				MessageBox.Show("Şirket Başarıyla Eklendi");
			}
		}
	}
}
