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
    public partial class frmKorisnik : Form
    {

        List<Korisnik> korisnikList = new List<Korisnik>();
        
        string akcija = "";
        
        int indeksSelektovanog = -1;

        
        public frmKorisnik()
        {
            
            
            InitializeComponent();

            
            
            
            dgKorisnik.AllowUserToAddRows = false;
            
            dgKorisnik.AllowUserToDeleteRows = false;
            
            dgKorisnik.ReadOnly = true;
            
            
            dgKorisnik.AutoGenerateColumns = false;

            
            
            
            dgKorisnik.Columns.Add("ID", "ID");
            dgKorisnik.Columns["ID"].Visible = false;
            
            
            dgKorisnik.Columns.Add("imeKupca", "Ime");
            
            
            dgKorisnik.Columns.Add("prezimeKupca", "Prezime");
            
            
            dgKorisnik.Columns.Add("adresaKupca", "Adresa");

            
            
            txtDisabled();
            btnChangeEnabled();
            btnSubmitDisabled();

            
            
            prikaziKorisnikeDGV();
        }

        
        private void txtDisabled()
        {
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            txtAdresa.Enabled = false;
        }

        
        private void txtEnabled()
        {
            txtIme.Enabled = true;
            txtPrezime.Enabled = true;
            txtAdresa.Enabled = true;
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
            txtAdresa.Text = "";
        }

        
        
        private void prikaziKorisnikeTxt()
        {
            
            int idSelektovanog = (int)dgKorisnik.SelectedRows[0].Cells["ID"].Value;
            
            Korisnik selektovaniKorisnik =
                korisnikList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
            
            if (selektovaniKorisnik != null)
            {
                txtIme.Text = selektovaniKorisnik.Ime;
                txtPrezime.Text = selektovaniKorisnik.Prezime;
                txtAdresa.Text = selektovaniKorisnik.Adresa;
            }
        }

        
        private void prikaziKorisnikeDGV()
        {
            
            korisnikList = new Korisnik().ucitajKorisnike();
            
            dgKorisnik.Rows.Clear();
            
            
            for (int i = 0; i < korisnikList.Count; i++)
            {
                dgKorisnik.Rows.Add();
                dgKorisnik.Rows[i].Cells["ID"].Value =
                    korisnikList[i].ID;
                dgKorisnik.Rows[i].Cells["imeKupca"].Value =
                    korisnikList[i].Ime;
                dgKorisnik.Rows[i].Cells["prezimeKupca"].Value =
                    korisnikList[i].Prezime;
                dgKorisnik.Rows[i].Cells["adresaKupca"].Value =
                    korisnikList[i].Adresa;
            }
            
            ponistiUnosTxt();
            
            
            dgKorisnik.CurrentCell = null;
            
            
            if (korisnikList.Count > 0)
            {
                if (indeksSelektovanog != -1)
                    dgKorisnik.Rows[indeksSelektovanog].Selected = true;
                else
                    dgKorisnik.Rows[0].Selected = true;
                prikaziKorisnikeTxt();
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
            
            
            if (dgKorisnik.SelectedRows.Count > 0)
            {
                
                if (MessageBox.Show("Da li zelite da obrisete odabranog korisnika?",
                "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    int idSelektovanog = (int)dgKorisnik.SelectedRows[0].Cells["ID"].Value;
                    
                    Korisnik selektovaniKorisnik = korisnikList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
                    
                    
                    if (selektovaniKorisnik != null)
                    {
                        selektovaniKorisnik.obrisiKorisnika();
                    }
                    
                    indeksSelektovanog = -1;
                    
                    prikaziKorisnikeDGV();
                }
            }
            else
            {
                MessageBox.Show("Nema unetih podataka");
            }
        }

        
        private void btnPromeni_Click(object sender, EventArgs e)
        {
            
            
            if (dgKorisnik.SelectedRows.Count > 0)
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
                    
                    int idSelektovanog = (int)dgKorisnik.SelectedRows[0].Cells["ID"].Value;
                    
                    Korisnik selektovaniKorisnik = korisnikList.Where(x => x.ID == idSelektovanog).FirstOrDefault();

                    
                    selektovaniKorisnik.Ime = txtIme.Text;
                    selektovaniKorisnik.Prezime = txtPrezime.Text;
                    selektovaniKorisnik.Adresa = txtAdresa.Text;
                    
                    
                    selektovaniKorisnik.azurirajKorisnika();
                    
                    indeksSelektovanog = dgKorisnik.SelectedRows[0].Index;
                }
                
                
                else if (akcija == "dodaj")
                {
                    
                    Korisnik kor = new Korisnik();
                    
                    kor.Ime = txtIme.Text;
                    kor.Prezime = txtPrezime.Text;
                    kor.Adresa = txtAdresa.Text;
                    
                    
                    kor.dodajKorisnika();
                    
                    indeksSelektovanog = dgKorisnik.Rows.Count;
                }
                
                txtDisabled();
                
                
                btnSubmitDisabled();
                
                btnChangeEnabled();
                
                akcija = "";
                
                prikaziKorisnikeDGV();
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

        
        private void dgKorisnik_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            
            if (dgKorisnik.CurrentRow != null)
            {
                
                dgKorisnik.Rows[dgKorisnik.CurrentRow.Index].Selected = true;
                
                
                prikaziKorisnikeTxt();
            }
        }

        private void mniXMLUvezi_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog oDlg = new OpenFileDialog();
            
            oDlg.InitialDirectory = "C:\\";
            
            oDlg.Filter = "xml Files (*.xml)|*.xml";
            
            if (DialogResult.OK == oDlg.ShowDialog())
            {
                
                
                KorisnikXML.uveziXML(oDlg.FileName);
            }
            
            
            prikaziKorisnikeDGV();

        }

        private void mniXMLIzvezi_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog sDlg = new SaveFileDialog();
            
            sDlg.InitialDirectory = "C:\\";
            
            sDlg.Filter = "xml Files (*.xml)|*.xml";
            
            if (DialogResult.OK == sDlg.ShowDialog())
            {
                
                
                KorisnikXML.izveziXML(sDlg.FileName, korisnikList);
            }

        }

       
    }
}