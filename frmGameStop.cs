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
    public partial class frmGameStop : Form
    {
        public frmGameStop()
        {
            
            InitializeComponent();
        }

        
        private void mniPodaciKupac_Click(object sender, EventArgs e)
        {
            
            CloseAllForms();
            
            frmKorisnik korisnikForm = new frmKorisnik();
            
            korisnikForm.MdiParent = this;
            
            korisnikForm.WindowState = FormWindowState.Maximized;
            
            korisnikForm.ControlBox = false;
            
            korisnikForm.Show();
        }

        
        private void mniPodaciIgrice_Click(object sender, EventArgs e)
        {
            
            CloseAllForms();
            
            frmIgrice igriceForm = new frmIgrice();
            
            igriceForm.MdiParent = this;
            
            igriceForm.WindowState = FormWindowState.Maximized;
            
            igriceForm.ControlBox = false;
            
            igriceForm.Show();
        }

        
        private void mniPodaciProdavac_Click(object sender, EventArgs e)
        {
            
            CloseAllForms();
            
            frmProdavac prodavacForm = new frmProdavac();
            
            prodavacForm.MdiParent = this;
            
            prodavacForm.WindowState = FormWindowState.Maximized;
            
            prodavacForm.ControlBox = false;
            
            prodavacForm.Show();
        }

        
        private void mniPodaciPlacanje_Click(object sender, EventArgs e)
        {
            
            CloseAllForms();
            
            frmPlacanje placanjeForm = new frmPlacanje();
            
            placanjeForm.MdiParent = this;
            
            placanjeForm.WindowState = FormWindowState.Maximized;
            
            placanjeForm.ControlBox = false;
            
            placanjeForm.Show();
        }

        
        private void mniPodaciProdaja_Click(object sender, EventArgs e)
        {
            
            CloseAllForms();
            
            frmProdaja prodajaForm = new frmProdaja();
            
            prodajaForm.MdiParent = this;
            
            prodajaForm.WindowState = FormWindowState.Maximized;
            
            prodajaForm.ControlBox = false;
            
            prodajaForm.Show();
        }

        
        private void CloseAllForms()
        {
            
            Form[] formToClose = null;
            int i = 1;
            
            foreach (Form form in Application.OpenForms)
            {
                
                if (form != this)
                {
                    
                    Array.Resize(ref formToClose, i);
                    
                    formToClose[i - 1] = form;
                    
                    i++;
                }
            }
            
            if (formToClose != null)
                
                for (int j = 0; j < formToClose.Length; j++)
                    formToClose[j].Dispose();
        }

        private void izvestajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzvestaj izvestajFrm = new frmIzvestaj();
            izvestajFrm.Show();

        }

        

    }
}
