﻿using AracKiralamaSistemi.KiralamaService;
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
    public partial class frm_KiralamaGoruntule : Form
    {
        public frm_KiralamaGoruntule()
        {
            InitializeComponent();
        }

		private void frm_KiralamaGoruntule_Load(object sender, EventArgs e)
		{
			using (var kiralamaSoapClient = new KiralamaWebServiceSoapClient())
			{
			 dgwKiralamaListesi.DataSource=	kiralamaSoapClient.SelectAllKiralamas();
			}
		}

		private void btnKiralamaSil_Click(object sender, EventArgs e)
		{
			using (var kiralamaSoapClient = new KiralamaWebServiceSoapClient())
			{
				dgwKiralamaListesi.DataSource = kiralamaSoapClient.SelectAllKiralamas();
			}
		}
	}
}
