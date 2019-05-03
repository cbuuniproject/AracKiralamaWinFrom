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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şirketİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // şirketİşlemleriToolStripMenuItem
            // 
            this.şirketİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şirketEkleToolStripMenuItem,
            this.şirketSilToolStripMenuItem});
            this.şirketİşlemleriToolStripMenuItem.Name = "şirketİşlemleriToolStripMenuItem";
            this.şirketİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.şirketİşlemleriToolStripMenuItem.Text = "Şirket İşlemleri";
            // 
            // şirketEkleToolStripMenuItem
            // 
            this.şirketEkleToolStripMenuItem.Name = "şirketEkleToolStripMenuItem";
            this.şirketEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.şirketEkleToolStripMenuItem.Text = "Şirket Ekle";
            // 
            // şirketSilToolStripMenuItem
            // 
            this.şirketSilToolStripMenuItem.Name = "şirketSilToolStripMenuItem";
            this.şirketSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.şirketSilToolStripMenuItem.Text = "Şirket Sil";
            // 
            // frm_AdminEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_AdminEkran";
            this.Text = "frm_AdminEkran";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem şirketİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şirketEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şirketSilToolStripMenuItem;
    }
}