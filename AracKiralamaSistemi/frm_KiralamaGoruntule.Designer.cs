﻿namespace AracKiralamaSistemi
{
    partial class frm_KiralamaGoruntule
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
			this.btnKiralamaSil = new System.Windows.Forms.Button();
			this.dgwKiralamaListesi = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgwKiralamaListesi)).BeginInit();
			this.SuspendLayout();
			// 
			// btnKiralamaSil
			// 
			this.btnKiralamaSil.Location = new System.Drawing.Point(442, 444);
			this.btnKiralamaSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnKiralamaSil.Name = "btnKiralamaSil";
			this.btnKiralamaSil.Size = new System.Drawing.Size(227, 97);
			this.btnKiralamaSil.TabIndex = 3;
			this.btnKiralamaSil.Text = "Kiralama Listele";
			this.btnKiralamaSil.UseVisualStyleBackColor = true;
			this.btnKiralamaSil.Click += new System.EventHandler(this.btnKiralamaSil_Click);
			// 
			// dgwKiralamaListesi
			// 
			this.dgwKiralamaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwKiralamaListesi.Location = new System.Drawing.Point(16, 15);
			this.dgwKiralamaListesi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgwKiralamaListesi.Name = "dgwKiralamaListesi";
			this.dgwKiralamaListesi.Size = new System.Drawing.Size(1035, 420);
			this.dgwKiralamaListesi.TabIndex = 2;
			// 
			// frm_KiralamaGoruntule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btnKiralamaSil);
			this.Controls.Add(this.dgwKiralamaListesi);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frm_KiralamaGoruntule";
			this.Text = "Kiralama Goruntule";
			this.Load += new System.EventHandler(this.frm_KiralamaGoruntule_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwKiralamaListesi)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKiralamaSil;
        private System.Windows.Forms.DataGridView dgwKiralamaListesi;
    }
}