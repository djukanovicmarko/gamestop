namespace Domaci8_9_10
{
    partial class frmIzvestaj
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.prodajaIgaraDataSet1 = new Domaci8_9_10.prodajaIgaraDataSet1();
            this.T_KorisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.T_KorisnikTableAdapter = new Domaci8_9_10.prodajaIgaraDataSet1TableAdapters.T_KorisnikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.prodajaIgaraDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_KorisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.T_KorisnikBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Domaci8_9_10.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(260, 228);
            this.reportViewer1.TabIndex = 0;
            // 
            // prodajaIgaraDataSet1
            // 
            this.prodajaIgaraDataSet1.DataSetName = "prodajaIgaraDataSet1";
            this.prodajaIgaraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // T_KorisnikBindingSource
            // 
            this.T_KorisnikBindingSource.DataMember = "T_Korisnik";
            this.T_KorisnikBindingSource.DataSource = this.prodajaIgaraDataSet1;
            // 
            // T_KorisnikTableAdapter
            // 
            this.T_KorisnikTableAdapter.ClearBeforeFill = true;
            // 
            // frmIzvestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmIzvestaj";
            this.Text = "frmIzvestaj";
            this.Load += new System.EventHandler(this.frmIzvestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodajaIgaraDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_KorisnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource T_KorisnikBindingSource;
        private prodajaIgaraDataSet1 prodajaIgaraDataSet1;
        private prodajaIgaraDataSet1TableAdapters.T_KorisnikTableAdapter T_KorisnikTableAdapter;
    }
}