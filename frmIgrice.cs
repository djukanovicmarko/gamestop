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
    public partial class frmIgrice : Form
    {
         
        List<Igrice> igriceList = new List<Igrice>();
        
        string akcija = "";
        
        int indeksSelektovanog = -1;


        public frmIgrice()
        {
            
            
            InitializeComponent();

            
            
            
            dgIgrice.AllowUserToAddRows = false;
            
            dgIgrice.AllowUserToDeleteRows = false;
            
            dgIgrice.ReadOnly = true;
            
            
            dgIgrice.AutoGenerateColumns = false;

            
            
            
            dgIgrice.Columns.Add("ID", "ID");
            dgIgrice.Columns["ID"].Visible = false;
            
            
            dgIgrice.Columns.Add("Naziv", "Naziv");
            
            
            dgIgrice.Columns.Add("Sifra", "Sifra");
            
            
            dgIgrice.Columns.Add("Tip", "Tip");
            
            
            txtDisabled();
            btnChangeEnabled();
            btnSubmitDisabled();

            
            
            prikaziIgriceDGV();
        }

        
        private void txtDisabled()
        {
            txtNaziv.Enabled = false;
            txtSifra.Enabled = false;
            txtTip.Enabled = false;
        }

        
        private void txtEnabled()
        {
            txtNaziv.Enabled = true;
            txtSifra.Enabled = true;
            txtTip.Enabled = true;
        }

        
        private void btnChangeDisabled()
        {
            btnDodaj.Enabled = false;
            btnPromeni.Enabled = false;
            btnObrisi.Enabled = false;
        }

        
        private void btnChangeEnabled()
        {
            btnDodaj.Enabled = true;
            btnPromeni.Enabled = true;
            btnObrisi.Enabled = true;
        }

        
        private void btnSubmitDisabled()
        {
            btnPotvrdi.Enabled = false;
            btnOdustani.Enabled = false;
        }

        
        private void btnSubmitEnabled()
        {
            btnPotvrdi.Enabled = true;
            btnOdustani.Enabled = true;
        }

        
        private void ponistiUnosTxt()
        {
            txtNaziv.Text = "";
            txtSifra.Text = "";
            txtTip.Text = "";
        }

        
        
        private void prikaziIgriceTxt()
        {
            int idSelektovanog = (int)dgIgrice.SelectedRows[0].Cells["ID"].Value;
            Igrice selektovanaIgrica =
                igriceList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
            if (selektovanaIgrica != null)
            {
                txtNaziv.Text = selektovanaIgrica.Naziv;
                txtSifra.Text = selektovanaIgrica.Sifra;
                txtTip.Text = selektovanaIgrica.Tip;
            }
        }

        
        private void prikaziIgriceDGV()
        {
            
            igriceList = new Igrice().ucitajIgrice();
            
            dgIgrice.Rows.Clear();
            
            
            for (int i = 0; i < igriceList.Count; i++)
            {
                dgIgrice.Rows.Add();
                dgIgrice.Rows[i].Cells["ID"].Value =
                    igriceList[i].ID;
                dgIgrice.Rows[i].Cells["Naziv"].Value =
                    igriceList[i].Naziv;
                dgIgrice.Rows[i].Cells["Sifra"].Value =
                    igriceList[i].Sifra;
                dgIgrice.Rows[i].Cells["Tip"].Value =
                    igriceList[i].Tip;
            }
            
            ponistiUnosTxt();
            
            
            dgIgrice.CurrentCell = null;
            
            
            if (igriceList.Count > 0)
            {
                if (indeksSelektovanog != -1)
                    dgIgrice.Rows[indeksSelektovanog].Selected = true;
                else
                    dgIgrice.Rows[0].Selected = true;
                prikaziIgriceTxt();
            }
        }

        
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            ponistiUnosTxt();
            
            txtEnabled();
            
            
            btnSubmitEnabled();
            
            
            btnChangeDisabled();
            
            akcija = "dodaj";
        }

        
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            
            
            if (dgIgrice.SelectedRows.Count > 0)
            {
                
                if (MessageBox.Show("Da li zelite da obrisete odabranu igricu?",
                "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    int idSelektovanog = (int)dgIgrice.SelectedRows[0].Cells["ID"].Value;
                    
                    Igrice selektovanaIgrica = igriceList.Where(x => x.ID ==
                        idSelektovanog).FirstOrDefault();
                    
                    
                    if (selektovanaIgrica != null)
                    {
                        selektovanaIgrica.obrisiIgrice();
                    }
                    
                    indeksSelektovanog = -1;
                    
                    prikaziIgriceDGV();
                }
            }
            else
            {
                MessageBox.Show("Nema podataka ili ni jedan red nije odabran!");
            }
        }

        
        private void btnPromeni_Click(object sender, EventArgs e)
        {
            
            
            if (dgIgrice.SelectedRows.Count > 0)
            {
                
                txtEnabled();
                
                
                btnSubmitEnabled();
                
                
                btnChangeDisabled();
                
                akcija = "promeni";
            }
            else
            {
                MessageBox.Show("Nema podataka ili ni jedan red nije odabran!");
            }
        }

        
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                if (akcija == "promeni")
                {
                    
                    int idSelektovanog = (int)dgIgrice.SelectedRows[0].Cells["ID"].Value;
                    
                    Igrice selektovanaIgrica = igriceList.Where(x => x.ID ==
                        idSelektovanog).FirstOrDefault();
                    
                    if (selektovanaIgrica != null)
                    {
                        selektovanaIgrica.Naziv = txtNaziv.Text;
                        selektovanaIgrica.Sifra = txtSifra.Text;
                        selektovanaIgrica.Tip = txtTip.Text;
                        
                        
                        selektovanaIgrica.azurirajIgrice();
                        
                        indeksSelektovanog = dgIgrice.SelectedRows[0].Index;
                    }
                }
                
                
                else if (akcija == "dodaj")
                {
                    
                    Igrice igre = new Igrice();
                    
                    igre.Naziv = txtNaziv.Text;
                    igre.Sifra = txtSifra.Text;
                    igre.Tip = txtTip.Text;
                    
                    
                    igre.dodajIgrice();
                    
                    indeksSelektovanog = dgIgrice.Rows.Count;
                }
                
                txtDisabled();
                
                
                btnSubmitDisabled();
                
                btnChangeEnabled();
                
                akcija = "";
                
                prikaziIgriceDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            
            txtDisabled();
            
            
            btnSubmitDisabled();
            
            btnChangeEnabled();
        }

        
        private void dgIgrice_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            
            if (dgIgrice.CurrentRow != null)
            {
                
                dgIgrice.Rows[dgIgrice.CurrentRow.Index].Selected = true;
                
                
                prikaziIgriceTxt();
            }
        }

    }
}
