using AracKiralamaSistemi.KullaniciService;
using AracKiralamaSistemi.MusteriService;
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
	public partial class frm_MusteriEkle : Form
	{
		public frm_MusteriEkle()
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
			Musteri musteri = new Musteri()
			{
				ad = txtAd.Text,
				soyad = txtSoyad.Text
			};
			using (var musteriSoapClient = new MusteriWebServiceSoapClient())
			{
				if (musteriSoapClient.InsertMusteri(musteri))
				{
					MessageBox.Show("Müşteri Başarıyla Eklendi");
					txtSoyad.Text = "";
					txtAd.Text = "";
					txtKullaniciAdi.Text = "";
					txtKullaniciSifre.Text = "";
				}
				else
					MessageBox.Show("Kayıt Yapılırken bir hata oluştu!");
			}
		}
	}
}
