namespace Domaci8_9_10
{
    partial class frmGameStop
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
            this.mniPodaci = new System.Windows.Forms.MenuStrip();
            this.meniPodaci = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPodaciKupac = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPodaciIgrice = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPodaciProdavac = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPodaciPlacanje = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPodaciProdaja = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // mniPodaci
            // 
            this.mniPodaci.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniPodaci,
            this.izvestajiToolStripMenuItem});
            this.mniPodaci.Location = new System.Drawing.Point(0, 0);
            this.mniPodaci.Name = "mniPodaci";
            this.mniPodaci.Size = new System.Drawing.Size(284, 24);
            this.mniPodaci.TabIndex = 1;
            this.mniPodaci.Text = "menuStrip1";
            // 
            // meniPodaci
            // 
            this.meniPodaci.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniPodaciKupac,
            this.mniPodaciIgrice,
            this.mniPodaciProdavac,
            this.mniPodaciPlacanje,
            this.mniPodaciProdaja});
            this.meniPodaci.Name = "meniPodaci";
            this.meniPodaci.Size = new System.Drawing.Size(55, 20);
            this.meniPodaci.Text = "Podaci";
            // 
            // mniPodaciKupac
            // 
            this.mniPodaciKupac.Name = "mniPodaciKupac";
            this.mniPodaciKupac.Size = new System.Drawing.Size(123, 22);
            this.mniPodaciKupac.Text = "Kupac";
            this.mniPodaciKupac.Click += new System.EventHandler(this.mniPodaciKupac_Click);
            // 
            // mniPodaciIgrice
            // 
            this.mniPodaciIgrice.Name = "mniPodaciIgrice";
            this.mniPodaciIgrice.Size = new System.Drawing.Size(123, 22);
            this.mniPodaciIgrice.Text = "Igrice";
            this.mniPodaciIgrice.Click += new System.EventHandler(this.mniPodaciIgrice_Click);
            // 
            // mniPodaciProdavac
            // 
            this.mniPodaciProdavac.Name = "mniPodaciProdavac";
            this.mniPodaciProdavac.Size = new System.Drawing.Size(123, 22);
            this.mniPodaciProdavac.Text = "Prodavac";
            this.mniPodaciProdavac.Click += new System.EventHandler(this.mniPodaciProdavac_Click);
            // 
            // mniPodaciPlacanje
            // 
            this.mniPodaciPlacanje.Name = "mniPodaciPlacanje";
            this.mniPodaciPlacanje.Size = new System.Drawing.Size(123, 22);
            this.mniPodaciPlacanje.Text = "Placanje";
            this.mniPodaciPlacanje.Click += new System.EventHandler(this.mniPodaciPlacanje_Click);
            // 
            // mniPodaciProdaja
            // 
            this.mniPodaciProdaja.Name = "mniPodaciProdaja";
            this.mniPodaciProdaja.Size = new System.Drawing.Size(123, 22);
            this.mniPodaciProdaja.Text = "Prodaja";
            this.mniPodaciProdaja.Click += new System.EventHandler(this.mniPodaciProdaja_Click);
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            this.izvestajiToolStripMenuItem.Click += new System.EventHandler(this.izvestajiToolStripMenuItem_Click);
            // 
            // frmGameStop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.mniPodaci);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mniPodaci;
            this.Name = "frmGameStop";
            this.Text = "GameStop";
            this.mniPodaci.ResumeLayout(false);
            this.mniPodaci.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mniPodaci;
        private System.Windows.Forms.ToolStripMenuItem meniPodaci;
        private System.Windows.Forms.ToolStripMenuItem mniPodaciKupac;
        private System.Windows.Forms.ToolStripMenuItem mniPodaciIgrice;
        private System.Windows.Forms.ToolStripMenuItem mniPodaciProdavac;
        private System.Windows.Forms.ToolStripMenuItem mniPodaciPlacanje;
        private System.Windows.Forms.ToolStripMenuItem mniPodaciProdaja;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
    }
}