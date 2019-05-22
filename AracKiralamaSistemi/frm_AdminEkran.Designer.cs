namespace AracKiralamaSistemi
{
    partial class frm_AdminEkran
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.şirketİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.şirketEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.şirketSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnListele = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şirketİşlemleriToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// şirketİşlemleriToolStripMenuItem
			// 
			this.şirketİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şirketEkleToolStripMenuItem,
            this.şirketSilToolStripMenuItem});
			this.şirketİşlemleriToolStripMenuItem.Name = "şirketİşlemleriToolStripMenuItem";
			this.şirketİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
			this.şirketİşlemleriToolStripMenuItem.Text = "Şirket İşlemleri";
			// 
			// şirketEkleToolStripMenuItem
			// 
			this.şirketEkleToolStripMenuItem.Name = "şirketEkleToolStripMenuItem";
			this.şirketEkleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.şirketEkleToolStripMenuItem.Text = "Şirket Ekle";
			this.şirketEkleToolStripMenuItem.Click += new System.EventHandler(this.şirketEkleToolStripMenuItem_Click);
			// 
			// şirketSilToolStripMenuItem
			// 
			this.şirketSilToolStripMenuItem.Name = "şirketSilToolStripMenuItem";
			this.şirketSilToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.şirketSilToolStripMenuItem.Text = "Şirket Sil";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(40, 67);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(963, 331);
			this.dataGridView1.TabIndex = 1;
			// 
			// btnListele
			// 
			this.btnListele.Location = new System.Drawing.Point(444, 439);
			this.btnListele.Name = "btnListele";
			this.btnListele.Size = new System.Drawing.Size(174, 38);
			this.btnListele.TabIndex = 2;
			this.btnListele.Text = "Şirket Listele";
			this.btnListele.UseVisualStyleBackColor = true;
			this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
			// 
			// frm_AdminEkran
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btnListele);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frm_AdminEkran";
			this.Text = "frm_AdminEkran";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem şirketİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şirketEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şirketSilToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnListele;
	}
}