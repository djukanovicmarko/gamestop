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
    public partial class frmPlacanje : Form
    {
        
        List<Placanje> placanjeList = new List<Placanje>();
        
        string akcija = "";
        
        int indeksSelektovanog = -1;
        public frmPlacanje()
        {
            
            
            InitializeComponent();

            
            
            
            dgPlacanje.AllowUserToAddRows = false;
            
            dgPlacanje.AllowUserToDeleteRows = false;
            
            dgPlacanje.ReadOnly = true;
            
            
            dgPlacanje.AutoGenerateColumns = false;

            
            
            
            dgPlacanje.Columns.Add("ID", "ID");
            dgPlacanje.Columns["ID"].Visible = false;
            
            
            dgPlacanje.Columns.Add("Nacin", "Nacin");
            
            
            dgPlacanje.Columns.Add("datumKupovine", "Datum");

            
            
            txtDisabled();
            btnChangeEnabled();
            btnSubmitDisabled();

            
            
            prikaziPlacanjeDGV();
        }

        
        private void txtDisabled()
        {
            txtNacin.Enabled = false;
            dtpPlacanje.Enabled = false;
        }

        
        private void txtEnabled()
        {
            txtNacin.Enabled = true;
            dtpPlacanje.Enabled = true;
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
            txtNacin.Text = "";
            dtpPlacanje.Value = DateTime.Now;
        }

        
        
        private void prikaziPlacanjeTxt()
        {
            
            int idSelektovanog = (int)dgPlacanje.SelectedRows[0].Cells["ID"].Value;
            
            Placanje selektovaniPlacanje =
                placanjeList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
            
            if (selektovaniPlacanje != null)
            {
                txtNacin.Text = selektovaniPlacanje.NacinPlacanja;
                dtpPlacanje.Value = selektovaniPlacanje.Datum;
            }
        }

        
        private void prikaziPlacanjeDGV()
        {
            
            placanjeList = new Placanje().ucitajPlacanje();
            
            dgPlacanje.Rows.Clear();
            
            
            for (int i = 0; i < placanjeList.Count; i++)
            {
                dgPlacanje.Rows.Add();
                dgPlacanje.Rows[i].Cells["ID"].Value =
                    placanjeList[i].ID;
                dgPlacanje.Rows[i].Cells["Nacin"].Value =
                    placanjeList[i].NacinPlacanja;
                dgPlacanje.Rows[i].Cells["datumKupovine"].Value =
                    placanjeList[i].Datum;
            }
            
            ponistiUnosTxt();
            
            
            dgPlacanje.CurrentCell = null;
            
            
            if (placanjeList.Count > 0)
            {
                if (indeksSelektovanog != -1)
                    dgPlacanje.Rows[indeksSelektovanog].Selected = true;
                else
                    dgPlacanje.Rows[0].Selected = true;
                prikaziPlacanjeTxt();
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
            
            
            if (dgPlacanje.SelectedRows.Count > 0)
            {
                
                if (MessageBox.Show("Da li zelite da obrisete odabrano placanje?",
                "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    int idSelektovanog = (int)dgPlacanje.SelectedRows[0].Cells["ID"].Value;
                    
                    Placanje selektovaniPlacanje = placanjeList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
                    
                    
                    if (selektovaniPlacanje != null)
                    {
                        selektovaniPlacanje.obrisiPlacanje();
                    }
                    
                    indeksSelektovanog = -1;
                    
                    prikaziPlacanjeDGV();
                }
            }
            else
            {
                MessageBox.Show("Nema unetih podataka");
            }
        }

        
        private void btnPromeni_Click(object sender, EventArgs e)
        {
            
            
            if (dgPlacanje.SelectedRows.Count > 0)
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
                    
                    int idSelektovanog = (int)dgPlacanje.SelectedRows[0].Cells["ID"].Value;
                    
                    Placanje selektovaniPlacanje = placanjeList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
                    
                    selektovaniPlacanje.NacinPlacanja = txtNacin.Text;
                    selektovaniPlacanje.Datum =  dtpPlacanje.Value.Date;
                    
                    
                    selektovaniPlacanje.azurirajPlacanje();
                    
                    indeksSelektovanog = dgPlacanje.SelectedRows[0].Index;
                }
                
                
                else if (akcija == "dodaj")
                {
                    
                    Placanje Placanje = new Placanje();
                    
                    Placanje.NacinPlacanja = txtNacin.Text;
                    Placanje.Datum = dtpPlacanje.Value;
                    
                    
                    Placanje.dodajPlacanje();
                    
                    indeksSelektovanog = dgPlacanje.Rows.Count;
                }
                
                txtDisabled();
                
                
                btnSubmitDisabled();
                
                btnChangeEnabled();
                
                akcija = "";
                
                prikaziPlacanjeDGV();
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

        
        private void dgPlacanjeovi_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            
            if (dgPlacanje.CurrentRow != null)
            {
                
                dgPlacanje.Rows[dgPlacanje.CurrentRow.Index].Selected = true;
                
                
                prikaziPlacanjeTxt();
            }
        }

        
    }
}
