namespace Domaci8_9_10
{
    partial class frmPlacanje
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
            this.label1 = new System.Windows.Forms.Label();
            this.box = new System.Windows.Forms.Label();
            this.txtNacin = new System.Windows.Forms.TextBox();
            this.dtpPlacanje = new System.Windows.Forms.DateTimePicker();
            this.dgPlacanje = new System.Windows.Forms.DataGridView();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlacanje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nacin Placanja:";
            // 
            // box
            // 
            this.box.AutoSize = true;
            this.box.Location = new System.Drawing.Point(113, 44);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(85, 13);
            this.box.TabIndex = 1;
            this.box.Text = "Datum Placanja:";
            // 
            // txtNacin
            // 
            this.txtNacin.Location = new System.Drawing.Point(225, 12);
            this.txtNacin.Name = "txtNacin";
            this.txtNacin.Size = new System.Drawing.Size(200, 20);
            this.txtNacin.TabIndex = 2;
            // 
            // dtpPlacanje
            // 
            this.dtpPlacanje.Location = new System.Drawing.Point(225, 38);
            this.dtpPlacanje.Name = "dtpPlacanje";
            this.dtpPlacanje.Size = new System.Drawing.Size(200, 20);
            this.dtpPlacanje.TabIndex = 3;
            // 
            // dgPlacanje
            // 
            this.dgPlacanje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPlacanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlacanje.Location = new System.Drawing.Point(12, 107);
            this.dgPlacanje.Name = "dgPlacanje";
            this.dgPlacanje.Size = new System.Drawing.Size(449, 143);
            this.dgPlacanje.TabIndex = 23;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOdustani.Location = new System.Drawing.Point(366, 78);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 22;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPotvrdi.Location = new System.Drawing.Point(285, 78);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 21;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnObrisi.Location = new System.Drawing.Point(204, 78);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 20;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPromeni
            // 
            this.btnPromeni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPromeni.Location = new System.Drawing.Point(123, 78);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromeni.TabIndex = 19;
            this.btnPromeni.Text = "Promeni";
            this.btnPromeni.UseVisualStyleBackColor = true;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDodaj.Location = new System.Drawing.Point(42, 78);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 18;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmPlacanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 262);
            this.Controls.Add(this.dgPlacanje);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPromeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtpPlacanje);
            this.Controls.Add(this.txtNacin);
            this.Controls.Add(this.box);
            this.Controls.Add(this.label1);
            this.Name = "frmPlacanje";
            this.Text = "Placanje";
            ((System.ComponentModel.ISupportInitialize)(this.dgPlacanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label box;
        private System.Windows.Forms.TextBox txtNacin;
        private System.Windows.Forms.DateTimePicker dtpPlacanje;
        private System.Windows.Forms.DataGridView dgPlacanje;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.Button btnDodaj;
    }
}