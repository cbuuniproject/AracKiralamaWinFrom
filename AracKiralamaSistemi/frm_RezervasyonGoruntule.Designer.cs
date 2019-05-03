namespace AracKiralamaSistemi
{
    partial class frm_RezervasyonGoruntule
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
            this.btnRezervasyonSil = new System.Windows.Forms.Button();
            this.dgwRezervasyonListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRezervasyonListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRezervasyonSil
            // 
            this.btnRezervasyonSil.Location = new System.Drawing.Point(618, 359);
            this.btnRezervasyonSil.Name = "btnRezervasyonSil";
            this.btnRezervasyonSil.Size = new System.Drawing.Size(170, 79);
            this.btnRezervasyonSil.TabIndex = 3;
            this.btnRezervasyonSil.Text = "Rezervasyon Sil";
            this.btnRezervasyonSil.UseVisualStyleBackColor = true;
            // 
            // dgwRezervasyonListesi
            // 
            this.dgwRezervasyonListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRezervasyonListesi.Location = new System.Drawing.Point(12, 12);
            this.dgwRezervasyonListesi.Name = "dgwRezervasyonListesi";
            this.dgwRezervasyonListesi.Size = new System.Drawing.Size(776, 341);
            this.dgwRezervasyonListesi.TabIndex = 2;
            // 
            // frm_RezervasyonGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRezervasyonSil);
            this.Controls.Add(this.dgwRezervasyonListesi);
            this.Name = "frm_RezervasyonGoruntule";
            this.Text = "frm_RezervasyonGoruntule";
            ((System.ComponentModel.ISupportInitialize)(this.dgwRezervasyonListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRezervasyonSil;
        private System.Windows.Forms.DataGridView dgwRezervasyonListesi;
    }
}