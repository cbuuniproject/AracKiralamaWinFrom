namespace AracKiralamaSistemi
{
    partial class frm_PersonelSil
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
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.dgwPersonelListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Location = new System.Drawing.Point(618, 359);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(170, 79);
            this.btnPersonelSil.TabIndex = 3;
            this.btnPersonelSil.Text = "Personel Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            // 
            // dgwPersonelListesi
            // 
            this.dgwPersonelListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonelListesi.Location = new System.Drawing.Point(12, 12);
            this.dgwPersonelListesi.Name = "dgwPersonelListesi";
            this.dgwPersonelListesi.Size = new System.Drawing.Size(776, 341);
            this.dgwPersonelListesi.TabIndex = 2;
            // 
            // frm_PersonelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.dgwPersonelListesi);
            this.Name = "frm_PersonelSil";
            this.Text = "frm_PersonelSil";
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonelListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.DataGridView dgwPersonelListesi;
    }
}