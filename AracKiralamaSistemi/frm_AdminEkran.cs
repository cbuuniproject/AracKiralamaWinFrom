﻿using AracKiralamaSistemi.SirketService;
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
    public partial class frm_AdminEkran : Form
    {
        public frm_AdminEkran()
        {
            InitializeComponent();
        }

		private void şirketEkleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm_Secim frm_Secim = new frm_Secim();
			frm_Secim.ShowDialog();
		}

		private void btnListele_Click(object sender, EventArgs e)
		{
			using (var sirketSoapClient = new SirketWebServiceSoapClient())
			{
				dataGridView1.DataSource = sirketSoapClient.SelectAllSirkets();
			}
		}
	}
}
