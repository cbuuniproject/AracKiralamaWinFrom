namespace AracKiralamaSistemi
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
            this.btnKiralamaSil.Location = new System.Drawing.Point(618, 359);
            this.btnKiralamaSil.Name = "btnKiralamaSil";
            this.btnKiralamaSil.Size = new System.Drawing.Size(170, 79);
            this.btnKiralamaSil.TabIndex = 3;
            this.btnKiralamaSil.Text = "Kiralama Sil";
            this.btnKiralamaSil.UseVisualStyleBackColor = true;
            // 
            // dgwKiralamaListesi
            // 
            this.dgwKiralamaListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKiralamaListesi.Location = new System.Drawing.Point(12, 12);
            this.dgwKiralamaListesi.Name = "dgwKiralamaListesi";
            this.dgwKiralamaListesi.Size = new System.Drawing.Size(776, 341);
            this.dgwKiralamaListesi.TabIndex = 2;
            // 
            // frm_KiralamaGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKiralamaSil);
            this.Controls.Add(this.dgwKiralamaListesi);
            this.Name = "frm_KiralamaGoruntule";
            this.Text = "frm_KiralamaGoruntule";
            ((System.ComponentModel.ISupportInitialize)(this.dgwKiralamaListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKiralamaSil;
        private System.Windows.Forms.DataGridView dgwKiralamaListesi;
    }
}