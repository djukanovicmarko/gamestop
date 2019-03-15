using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Domaci8_9_10
{
    public partial class frmIzvestaj : Form
    {
        public frmIzvestaj()
        {
            InitializeComponent();
        }

        private void frmIzvestaj_Load(object sender, EventArgs e)
        {
            
            T_KorisnikBindingSource.DataSource = new Korisnik().ucitajKorisnike();

            this.reportViewer1.RefreshReport();
        }
    }
}
