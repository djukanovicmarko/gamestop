using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Domaci8_9_10
{
    public partial class frmProdaja : Form
    {
        
        List<Prodaja> prodajaList = new List<Prodaja>();
        
        string akcija = "";
        
        int indeksSelektovanog = -1;
        public frmProdaja()
        {

            
            
            InitializeComponent();

            
            
            
            dgProdaja.AllowUserToAddRows = false;
            
            dgProdaja.AllowUserToDeleteRows = false;
            
            dgProdaja.ReadOnly = true;
            
            
            dgProdaja.AutoGenerateColumns = false;

            
            
            
            dgProdaja.Columns.Add("ID", "ID");
            dgProdaja.Columns["ID"].Visible = false;
            
            
            dgProdaja.Columns.Add("datumKupovine", "Datum");
            
            
            dgProdaja.Columns.Add("Ime", "Ime");
            
            
            dgProdaja.Columns.Add("Prezime", "Prezime");
            dgProdaja.Columns.Add("Adresa", "Adresa");
            
            
            dgProdaja.Columns.Add("Naziv", "Naziv");
            
            
            dgProdaja.Columns.Add("Nacin","Nacin");
            dgProdaja.Columns.Add("Ime", "Ime");
            dgProdaja.Columns.Add("Prezime","Prezime");
            
            
            

            
            
            List<Korisnik> KorisnikList = new Korisnik().ucitajKorisnike();
            
            
            
            
            
            cbxKorisnik.Items.Add(new DictionaryEntry("Odaberite kupca", 0));
            
            foreach (Korisnik kor in KorisnikList)
            {
                
                
                cbxKorisnik.Items.Add(new DictionaryEntry(
                    kor.Ime + kor.Prezime, kor.ID));
            }
            
            
            cbxKorisnik.DisplayMember = "Key";
            cbxKorisnik.ValueMember = "Value";
            
            
            cbxKorisnik.DataSource = cbxKorisnik.Items;




            
            
            List<Igrice> IgriceList = new Igrice().ucitajIgrice();
            
            
            
            
            
            foreach (Igrice igrice in IgriceList)
            {
                
                
                cbxIgrice.Items.Add(new DictionaryEntry(
                    igrice.Naziv, igrice.ID));
            }
            
            
            cbxIgrice.DisplayMember = "Key";
            cbxIgrice.ValueMember = "Value";
            
            
            cbxIgrice.DataSource = cbxIgrice.Items;



            
            
            List<Placanje> placanjeList = new Placanje().ucitajPlacanje();
            
            
            
            
            
            cbxPlacanje.Items.Add(new DictionaryEntry("Odaberite Placanje", 0));
            
            foreach (Placanje placanje in placanjeList)
            {
                
                
                cbxPlacanje.Items.Add(new DictionaryEntry(
                    placanje.NacinPlacanja, placanje.ID));
            }
            
            
            cbxPlacanje.DisplayMember = "Key";
            cbxPlacanje.ValueMember = "Value";
            
            
            cbxPlacanje.DataSource = cbxPlacanje.Items;

            
            
            List<Prodavac> prodavacList = new Prodavac().ucitajProdavce();
            
            
            
            
            
            foreach (Prodavac prodavac in prodavacList)
            {
                
                
                cbxProdavac.Items.Add(new DictionaryEntry(prodavac.Ime + prodavac.Prezime, prodavac.ID));
            }
            
            
            cbxProdavac.DisplayMember = "Key";
            cbxProdavac.ValueMember = "Value";
            
            
            cbxProdavac.DataSource = cbxProdavac.Items;

            
            
            txtDisabled();
            btnChangeEnabled();
            btnSubmitDisabled();

            
            
            prikaziProdajuDGV();
        }

        
        private void txtDisabled()
        {
            dtpProdaje.Enabled = false;
            cbxKorisnik.Enabled = false;
            cbxPlacanje.Enabled = false;
            cbxIgrice.Enabled = false;
            cbxProdavac.Enabled = false;
        }

        
        private void txtEnabled()
        {
            dtpProdaje.Enabled = true;
            cbxKorisnik.Enabled = true;
            cbxPlacanje.Enabled = true;
            cbxIgrice.Enabled = true;
            cbxProdavac.Enabled = true;
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
            dtpProdaje.Value = DateTime.Now;
            cbxKorisnik.SelectedIndex = 0;
            cbxPlacanje.SelectedIndex = 0;
            cbxIgrice.SelectedIndex = -1;
            cbxProdavac.SelectedIndex = -1;
        }

        
        
        private void prikaziProdajuTxt()
        {
            
            int idSelektovanog = (int)dgProdaja.SelectedRows[0].Cells["ID"].Value;
            
            Prodaja selektovanaProdaja =
                prodajaList.Where(x => x.ID == idSelektovanog).FirstOrDefault();

            dtpProdaje.Value = selektovanaProdaja.Datum;
            
            
            
            int korIndex = cbxKorisnik.FindString(
                selektovanaProdaja.Korisnik.Ime + " " +
                selektovanaProdaja.Korisnik.Prezime);
            cbxKorisnik.SelectedIndex = korIndex;
            
            
            
            int PlacanjeIndex = cbxPlacanje.FindString(
                selektovanaProdaja.Placanje.NacinPlacanja);
            cbxPlacanje.SelectedIndex = PlacanjeIndex;
            
            int igriceIndex = cbxIgrice.FindString(
                selektovanaProdaja.Igrice.Tip);
            int prodavacIndex = cbxProdavac.FindString(
                selektovanaProdaja.Prodavac.Sifra);
        }

        
        private void prikaziProdajuDGV()
        {
            
            prodajaList = new Prodaja().ucitajProdaju();
            
            dgProdaja.Rows.Clear();
            
            
            for (int i = 0; i < prodajaList.Count; i++)
            {
                dgProdaja.Rows.Add();
                dgProdaja.Rows[i].Cells["ID"].Value =
                    prodajaList[i].ID;
                dgProdaja.Rows[i].Cells["Datum"].Value =
                    prodajaList[i].Datum;
                dgProdaja.Rows[i].Cells["imeKupca"].Value =
                    prodajaList[i].Korisnik.Ime;
                dgProdaja.Rows[i].Cells["prezimeKupca"].Value =
                    prodajaList[i].Korisnik.Prezime;
                dgProdaja.Rows[i].Cells["Naziv"].Value =
                    prodajaList[i].Igrice.Naziv;
                dgProdaja.Rows[i].Cells["Nacin"].Value =
                    prodajaList[i].Placanje.NacinPlacanja;
                dgProdaja.Rows[i].Cells["Ime"].Value =
                    prodajaList[i].Prodavac.Ime;
                dgProdaja.Rows[i].Cells["Prezime"].Value =
                    prodajaList[i].Prodavac.Prezime;
            }
            
            ponistiUnosTxt();
            
            
            dgProdaja.CurrentCell = null;
            
            
            if (prodajaList.Count > 0)
            {
                if (indeksSelektovanog != -1)
                    dgProdaja.Rows[indeksSelektovanog].Selected = true;
                else
                    dgProdaja.Rows[0].Selected = true;
                prikaziProdajuTxt();
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
            
            
            if (dgProdaja.SelectedRows.Count > 0)
            {
                
                if (MessageBox.Show("Da li zelite da obrisete odabranu prodaju?",
                "Potvrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    int idSelektovanog = (int)dgProdaja.SelectedRows[0].Cells["ID"].Value;
                    
                    Prodaja selektovanaProdaja =
                        prodajaList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
                    
                    
                    selektovanaProdaja.obrisiProdaju();
                    
                    indeksSelektovanog = -1;
                    
                    prikaziProdajuDGV();
                    
                }
            }
            else
            {
                MessageBox.Show("Nema unetih podataka");
            }
        }

        
        private void btnPromeni_Click(object sender, EventArgs e)
        {
            
            
            if (dgProdaja.SelectedRows.Count > 0)
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
                    
                    int idSelektovanog = (int)dgProdaja.SelectedRows[0].Cells["ID"].Value;
                    
                    Prodaja selektovanaProdaja =
                        prodajaList.Where(x => x.ID == idSelektovanog).FirstOrDefault();
                    
                    selektovanaProdaja.Datum = dtpProdaje.Value.Date;
                    selektovanaProdaja.Korisnik = new Korisnik();
                    selektovanaProdaja.Korisnik.ID =
                        Int32.Parse(cbxKorisnik.SelectedValue.ToString());
                    selektovanaProdaja.Placanje = new Placanje();
                    selektovanaProdaja.Placanje.ID =
                        Int32.Parse(cbxPlacanje.SelectedValue.ToString());
                    
                    selektovanaProdaja.Igrice = new Igrice();
                    selektovanaProdaja.Igrice.ID =
                        Int32.Parse(cbxIgrice.SelectedValue.ToString());
                    selektovanaProdaja.Prodavac = new Prodavac();
                    selektovanaProdaja.Prodavac.ID = 
                        Int32.Parse(cbxProdavac.SelectedValue.ToString());
                    
                    
                    
                    selektovanaProdaja.azurirajProdaju();
                    
                    indeksSelektovanog = dgProdaja.SelectedRows[0].Index;
                }
                
                
                else if (akcija == "dodaj")
                {
                    
                    Prodaja prodaja = new Prodaja();
                    
                    
                    
                    prodaja.Datum = dtpProdaje.Value.Date;
                    prodaja.Korisnik = new Korisnik();
                    prodaja.Korisnik.ID =
                        Int32.Parse(cbxKorisnik.SelectedValue.ToString());
                    prodaja.Placanje = new Placanje();
                    prodaja.Placanje.ID =
                        Int32.Parse(cbxPlacanje.SelectedValue.ToString());
                    
                    prodaja.Igrice = new Igrice();
                    prodaja.Igrice.ID =
                        Int32.Parse(cbxIgrice.SelectedValue.ToString());
                    prodaja.Prodavac = new Prodavac();
                        Int32.Parse(cbxProdavac.SelectedValue.ToString());
                    
                    
                    prodaja.dodajProdaju();
                    
                    indeksSelektovanog = dgProdaja.Rows.Count;
                }
                
                txtDisabled();
                
                
                btnSubmitDisabled();
                
                btnChangeEnabled();
                
                prikaziProdajuDGV();
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

        
        private void dgProdaja_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            
            if (dgProdaja.CurrentRow != null)
            {
                
                dgProdaja.Rows[dgProdaja.CurrentRow.Index].Selected = true;
                
                prikaziProdajuTxt();
                
            }
        }

        


    }
}
