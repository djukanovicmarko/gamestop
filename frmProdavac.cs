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
    public partial class frmProdavac : Form
    {
        
        List<Prodavac> prodavacList = new List<Prodavac>();
        
        string akcija = "";
        
        int indeksSelektovanog = -1;

        public frmProdavac()
        {

            
            
            InitializeComponent();

            
            
            
            dgProdavac.AllowUserToAddRows = false;
            
            dgProdavac.AllowUserToDeleteRows = false;
            
            dgProdavac.ReadOnly = true;
            
            
            dgProdavac.AutoGenerateColumns = false;

            
            
            
            dgProdavac.Columns.Add("ID", "ID");
            dgProdavac.Columns["ID"].Visible = false;
            
            
            dgProdavac.Columns.Add("imeProdavca", "Ime");
            
            
            dgProdavac.Columns.Add("prezimeProdavca", "Prezime");
            
            
            dgProdavac.Columns.Add("sifraProdavca", "Sifra");
            
            
            txtDisabled();
            btnChangeEnabled();
            btnSubmitDisabled();

            
            
            prikaziProdavceDGV();
        }

        
        private void txtDisabled()
        {
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            txtSifra.Enabled = false;
        }

        
        private void txtEnabled()
        {
            txtIme.Enabled = true;
            txtPrezime.Enabled = true;
            txtSifra.Enabled = true;
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
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtSifra.Text = "";
        }

        
        
        private void prikaziProdavceTxt()
        {
            
            int idSelektovanog = (int)dgProdavac.SelectedRows[0].Cells["ID"].Value;
            
            Prodavac selektovaniProdavac =
                prodavacList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
            
            if (selektovaniProdavac != null)
            {
                txtIme.Text = selektovaniProdavac.Ime;
                txtPrezime.Text = selektovaniProdavac.Prezime;
                txtSifra.Text = selektovaniProdavac.Sifra;
                
                
                

            }
        }

        
        private void prikaziProdavceDGV()
        {
            
            prodavacList = new Prodavac().ucitajProdavce();
            
            dgProdavac.Rows.Clear();
            
            
            for (int i = 0; i < prodavacList.Count; i++)
            {
                dgProdavac.Rows.Add();
                dgProdavac.Rows[i].Cells["ID"].Value =
                    prodavacList[i].ID;
                dgProdavac.Rows[i].Cells["imeProdavca"].Value =
                    prodavacList[i].Ime;
                dgProdavac.Rows[i].Cells["prezimeProdavca"].Value =
                    prodavacList[i].Prezime;
                dgProdavac.Rows[i].Cells["sifraProdavca"].Value =
                    prodavacList[i].Sifra;
            }
            
            ponistiUnosTxt();
            
            
            dgProdavac.CurrentCell = null;
            
            
            if (prodavacList.Count > 0)
            {
                if (indeksSelektovanog != -1)
                    dgProdavac.Rows[indeksSelektovanog].Selected = true;
                else
                    dgProdavac.Rows[0].Selected = true;
                prikaziProdavceTxt();
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
            
            
            if (dgProdavac.SelectedRows.Count > 0)
            {
                
                if (MessageBox.Show("Da li zelite da obrisete odabranog prodavca?",
                "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    int idSelektovanog = (int)dgProdavac.SelectedRows[0].Cells["ID"].Value;
                    
                    Prodavac selektovaniProdavac = prodavacList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
                    
                    
                    if (selektovaniProdavac != null)
                    {
                        selektovaniProdavac.obrisiProdavce();
                    }
                    
                    indeksSelektovanog = -1;
                    
                    prikaziProdavceDGV();
                }
            }
            else
            {
                MessageBox.Show("Nema unetih podataka");
            }
        }

        
        private void btnPromeni_Click(object sender, EventArgs e)
        {
            
            
            if (dgProdavac.SelectedRows.Count > 0)
            {
                
                txtEnabled();
                
                
                btnSubmitEnabled();
                
                
                btnChangeDisabled();
                
                akcija = "promeni";
            }
            else
            {
                MessageBox.Show("Nema unetih podataka");
            }
        }

        
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                if (akcija == "promeni")
                {
                    
                    int idSelektovanog = (int)dgProdavac.SelectedRows[0].Cells["ID"].Value;
                    
                    Prodavac selektovaniProdavac = prodavacList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
                    
                    selektovaniProdavac.Ime = txtIme.Text;
                    selektovaniProdavac.Prezime = txtPrezime.Text;
                    selektovaniProdavac.Sifra = txtSifra.Text;
                    Prodavac prod = new Prodavac();
                    
                    
                    
                    selektovaniProdavac.azurirajProdavce();
                    
                    indeksSelektovanog = dgProdavac.SelectedRows[0].Index;
                }
                
                
                else if (akcija == "dodaj")
                {
                    
                    Prodavac prod = new Prodavac();
                    
                    
                    prod.Ime = txtIme.Text;
                    prod.Prezime = txtPrezime.Text;
                    prod.Sifra = txtSifra.Text;
                    
                    
                    prod.dodajProdavce();
                    
                    indeksSelektovanog = dgProdavac.Rows.Count;
                }
                
                txtDisabled();
                
                
                btnSubmitDisabled();
                
                btnChangeEnabled();
                
                prikaziProdavceDGV();
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

        
        private void dgProdavac_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            
            if (dgProdavac.CurrentRow != null)
            {
                
                dgProdavac.Rows[dgProdavac.CurrentRow.Index].Selected = true;
                
                
                prikaziProdavceTxt();
            }
        }

        
    }
}
