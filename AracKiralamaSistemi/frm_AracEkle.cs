using AracKiralamaSistemi.AracService;
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
    public partial class frm_AracEkle : Form
    {
        public frm_AracEkle()
        {
            InitializeComponent();
        }

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			Arac arac = new Arac() {
				airbagSayisi = Convert.ToByte(txtAirbagSayisi.Text),
				bagajHacmi = short.Parse(txtBagajHacmi.Text),
				anlikKm = Convert.ToInt32(txtAnlikKm.Text),
				gunlukFiyat = Convert.ToInt32(txtFiyat.Text),
				gunlukMaxKmSiniri = short.Parse(txtGunlukKmLimit.Text),
				koltukSayisi = Convert.ToByte(txtKoltukSayisi.Text),
				marka = txtMarka.Text,
				minEhliyetYasi=Convert.ToInt32(txtEhliyetYasi.Text),
				minYasSiniri=short.Parse(txtYasSiniri.Text),
				model=txtModel.Text,
				sirketId=5
			};
			using (var aracSoapClient = new AracWebServiceSoapClient())
			{
				if (aracSoapClient.InsertArac(arac))
				{
					MessageBox.Show("Araç Başarıyla Eklendi");
				}
				else
					MessageBox.Show("Kayıt Yapılırken bir hata oluştu!");

			}
		}
	}
}
