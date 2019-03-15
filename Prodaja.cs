using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
namespace Domaci8_9_10
{
    [Serializable]
    class Prodaja
    {

        public int id;
        public Prodavac prodavac;
        public Korisnik korisnik;
        public Igrice igrice;
        public Placanje placanje;
        public DateTime datum;


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public Prodavac Prodavac
        {
            get { return prodavac; }
            set
            {
                if (value == null)
                    throw new Exception("Morate uneti naziv prodavca!!!");
                prodavac = value;
            }
        }

        public Korisnik Korisnik
        {
            get { return korisnik; }
            set
            {
                if (value == null)
                    throw new Exception("Morate uneti ime korisnika!!!");
                korisnik = value;
            }
        }

        public Igrice Igrice
        {
            get { return igrice; }
            set
            {
                if (value == null)
                    throw new Exception("Morate uneti naziv igrice!!!");
                igrice = value;
            }
        }

        public Placanje Placanje
        {
            get { return placanje; }
            set
            {
                if (value == null)
                    throw new Exception("Morate uneti nacin placanja!!!");
                placanje = value;
            }
        }


        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        private string _connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Marko\\Desktop\\Domaci C#\\Domaci8-9-10\\Domaci8-9-10\\prodajaIgara.mdf;Integrated Security=True;User Instance=True";

        public void dodajProdaju()
        {
            string insertProdajaSql = "INSERT INTO T_Prodaja (Datum, idkorisnika, idigrice, idplacanja, idprodavca) VALUES (@Datum, @idkorisnika, @idigrice, @idplacanja, @idprodavca)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand prodajaCommand = connection.CreateCommand();
                prodajaCommand.CommandText = insertProdajaSql;
                prodajaCommand.Parameters.Add(new SqlParameter("@Datum", Datum));
                prodajaCommand.Parameters.Add(new SqlParameter("@idkorisnika", Korisnik.ID));
                prodajaCommand.Parameters.Add(new SqlParameter("@idigrice", Igrice.ID));
                prodajaCommand.Parameters.Add(new SqlParameter("@idplacanja", Placanje.ID));
                prodajaCommand.Parameters.Add(new SqlParameter("@idprodavca", Prodavac.ID));
                connection.Open();
                int insertedId = (int)prodajaCommand.ExecuteScalar();
            }
        }

        public void azurirajProdaju()
        {
            string updatePrijavaSql =
                "UPDATE T_Prodaja " +
                "SET Datum = @Datum, idkorisnika = @idkorsnika, idprodavca = @idprodavca, idigrice = @idigrice, idplacanja = @idplacanja " +
                "WHERE idprodaje = @idprodaje;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand updateCommand = connection.CreateCommand();
                updateCommand.CommandText = updatePrijavaSql;
                updateCommand.Parameters.Add(new SqlParameter("@idprodaje", ID));
                updateCommand.Parameters.Add(new SqlParameter("@Datum", Datum));
                updateCommand.Parameters.Add(new SqlParameter("@idkorisnika", Korisnik.ID));
                updateCommand.Parameters.Add(new SqlParameter("@idprodavca", Prodavac.ID));
                updateCommand.Parameters.Add(new SqlParameter("@idigrice", Igrice.ID));
                updateCommand.Parameters.Add(new SqlParameter("@idplacanja", Placanje.ID));
                connection.Open();
                updateCommand.ExecuteNonQuery();


            }
        }

        public void obrisiProdaju()
        {
            string deleteSql =
                "DELETE FROM T_Prodaja WHERE idprodaje = @idprodaje;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = deleteSql;
                command.Parameters.Add(new SqlParameter("@idprodaje", ID));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Prodaja> ucitajProdaju()
        {
            List<Prodaja> prodaje = new List<Prodaja>();
            string queryString =
               "SELECT kor.idkorisnika, kor.Ime as ImeKupca, kor.Prezime as PrezimeKupca, kor.Adresa, igre.idigrice, igre.Naziv, pro.idprodaje, pro.Datum as datumProdaje, placanje.nacinPlacanja,  prod.idprodavca, prod.Ime as ImeProdavca, prod.Prezime as PrezimeProdavca FROM T_Korisnik kor, T_Prodaja pro, T_Prodavac prod, T_Igrice igre, T_Placanje placanje WHERE kor.idkorisnika = pro.idkorisnikaFK AND igre.idigrice = pro.idigriceFK  AND placanje.idplacanja = pro.idplacanjaFK AND prod.idprodavca = pro.idprodavcaFK " +
                "ORDER BY pro.idprodaje";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                
                SqlCommand command = connection.CreateCommand();
                command.CommandText = queryString;
                connection.Open();

                

                SqlDataReader reader = command.ExecuteReader();
                {
                    int prethodniIdProdaje = 0;
                    Prodaja prodaja = new Prodaja();
                    while (reader.Read())
                    {
                        int idprodaje = Int32.Parse(reader["idprodaje"].ToString());
                        if (idprodaje != prethodniIdProdaje)
                        {
                            prethodniIdProdaje = idprodaje;
                            prodaja = new Prodaja();
                            prodaje.Add(prodaja);
                            prodaja.ID = idprodaje;

                            Korisnik kor = new Korisnik();
                            kor.ID = Int32.Parse(reader["idkorisnika"].ToString());
                            kor.Ime = reader["ImeKupca"].ToString();
                            kor.Prezime = reader["PrezimeKupca"].ToString();
                            prodaja.Korisnik = kor;

                           
                            Igrice igre = new Igrice();
                            igre.ID = Int32.Parse(reader["idigrice"].ToString());
                            igre.Naziv = reader["Naziv"].ToString();
                            prodaja.Igrice = igre;

                            Placanje placanje = new Placanje();
                            placanje.ID = Int32.Parse(reader["idplacanja"].ToString());
                            placanje.NacinPlacanja = reader["Nacin"].ToString();
                            prodaja.Placanje = placanje;

                            Prodavac prod = new Prodavac();
                            prod.ID = Int32.Parse(reader["idprodavca"].ToString());
                            prod.Ime = reader["ImeProdavca"].ToString();
                            prod.Prezime = reader["PrezimeProdavca"].ToString();
                            prodaja.Prodavac = prod;



                            prodaja.Datum = DateTime.Parse(reader["datumPlacanja"].ToString());
                        }
                    }
                    return prodaje;
                }
            }
        }
    }
}