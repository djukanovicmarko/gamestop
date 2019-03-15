namespace Domaci8_9_10
{
    partial class frmProdaja
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
            this.box = new System.Windows.Forms.Label();
            this.dtpProdaje = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxKorisnik = new System.Windows.Forms.ComboBox();
            this.cbxIgrice = new System.Windows.Forms.ComboBox();
            this.cbxPlacanje = new System.Windows.Forms.ComboBox();
            this.cbxProdavac = new System.Windows.Forms.ComboBox();
            this.dgProdaja = new System.Windows.Forms.DataGridView();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdaja)).BeginInit();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.AutoSize = true;
            this.box.Location = new System.Drawing.Point(203, 19);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(41, 13);
            this.box.TabIndex = 2;
            this.box.Text = "Datum:";
            // 
            // dtpProdaje
            // 
            this.dtpProdaje.Location = new System.Drawing.Point(267, 13);
            this.dtpProdaje.Name = "dtpProdaje";
            this.dtpProdaje.Size = new System.Drawing.Size(200, 20);
            this.dtpProdaje.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kupac:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prodavac:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Igrica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nacin Placanja:";
            // 
            // cbxKorisnik
            // 
            this.cbxKorisnik.FormattingEnabled = true;
            this.cbxKorisnik.Location = new System.Drawing.Point(298, 39);
            this.cbxKorisnik.Name = "cbxKorisnik";
            this.cbxKorisnik.Size = new System.Drawing.Size(121, 21);
            this.cbxKorisnik.TabIndex = 8;
            // 
            // cbxIgrice
            // 
            this.cbxIgrice.FormattingEnabled = true;
            this.cbxIgrice.Location = new System.Drawing.Point(298, 66);
            this.cbxIgrice.Name = "cbxIgrice";
            this.cbxIgrice.Size = new System.Drawing.Size(121, 21);
            this.cbxIgrice.TabIndex = 9;
            // 
            // cbxPlacanje
            // 
            this.cbxPlacanje.FormattingEnabled = true;
            this.cbxPlacanje.Location = new System.Drawing.Point(298, 93);
            this.cbxPlacanje.Name = "cbxPlacanje";
            this.cbxPlacanje.Size = new System.Drawing.Size(121, 21);
            this.cbxPlacanje.TabIndex = 10;
            // 
            // cbxProdavac
            // 
            this.cbxProdavac.FormattingEnabled = true;
            this.cbxProdavac.Location = new System.Drawing.Point(298, 125);
            this.cbxProdavac.Name = "cbxProdavac";
            this.cbxProdavac.Size = new System.Drawing.Size(121, 21);
            this.cbxProdavac.TabIndex = 11;
            // 
            // dgProdaja
            // 
            this.dgProdaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProdaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdaja.Location = new System.Drawing.Point(12, 186);
            this.dgProdaja.Name = "dgProdaja";
            this.dgProdaja.Size = new System.Drawing.Size(632, 94);
            this.dgProdaja.TabIndex = 29;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOdustani.Location = new System.Drawing.Point(460, 157);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 28;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPotvrdi.Location = new System.Drawing.Point(379, 157);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 27;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnObrisi.Location = new System.Drawing.Point(298, 157);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 26;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPromeni
            // 
            this.btnPromeni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPromeni.Location = new System.Drawing.Point(217, 157);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromeni.TabIndex = 25;
            this.btnPromeni.Text = "Promeni";
            this.btnPromeni.UseVisualStyleBackColor = true;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDodaj.Location = new System.Drawing.Point(136, 157);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 24;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmProdaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 292);
            this.Controls.Add(this.dgProdaja);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPromeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbxProdavac);
            this.Controls.Add(this.cbxPlacanje);
            this.Controls.Add(this.cbxIgrice);
            this.Controls.Add(this.cbxKorisnik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpProdaje);
            this.Controls.Add(this.box);
            this.Name = "frmProdaja";
            this.Text = "frmProdaja";
            ((System.ComponentModel.ISupportInitialize)(this.dgProdaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label box;
        private System.Windows.Forms.DateTimePicker dtpProdaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxKorisnik;
        private System.Windows.Forms.ComboBox cbxIgrice;
        private System.Windows.Forms.ComboBox cbxPlacanje;
        private System.Windows.Forms.ComboBox cbxProdavac;
        private System.Windows.Forms.DataGridView dgProdaja;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.Button btnDodaj;
    }
}