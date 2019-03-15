using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Domaci8_9_10
{
    [Serializable]
    public class Korisnik
    {
        private int id;
        private string ime;
        private string prezime;
        private string adresa;


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Ime
        {
            get { return ime; }
            set
            {
                if (value == "")
                    throw new Exception("Morate uneti ime!!!");
                ime = value;
            }
        }

        public string Prezime
        {
            get { return prezime; }
            set
            {
                if (value == "")
                    throw new Exception("Morate uneti prezime!!!");
                prezime = value;
            }
        }

        public string Adresa
        {
            get { return adresa; }
            set
            {
                if (value == "")
                    throw new Exception("Morate uneti adresu!!!");
                adresa = value;
            }
        }

        private string _connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Marko\\Desktop\\Domaci C#\\Domaci8-9-10\\Domaci8-9-10\\prodajaIgara.mdf;Integrated Security=True;User Instance=True";

        public void dodajKorisnika()
        {
            string insertSql = "INSERT INTO T_Korisnik " +
                "(Ime, Prezime, Adresa) VALUES " +
                "(@Ime, @Prezime, @Adresa)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = insertSql;
                command.Parameters.Add(new SqlParameter("@Ime", Ime));
                command.Parameters.Add(new SqlParameter("@Prezime", Prezime));
                command.Parameters.Add(new SqlParameter("@Adresa", Adresa));
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void azurirajKorisnika()
        {
            string updateSql =
                "UPDATE T_Korisnik " +
                "SET Ime= @Ime, Prezime = @Prezime, Adresa = @Adresa " +
                "WHERE idkorisnika = @idkorisnika;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = updateSql;
                command.Parameters.Add(new SqlParameter("@idkorisnika", ID));
                command.Parameters.Add(new SqlParameter("@Ime", Ime));
                command.Parameters.Add(new SqlParameter("@Prezime", Prezime));
                command.Parameters.Add(new SqlParameter("@Adresa", Adresa));
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void obrisiKorisnika()
        {
            string deleteSql =
                "DELETE FROM T_Korisnik WHERE idkorisnika = @idkorisnika;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = deleteSql;
                command.Parameters.Add(new SqlParameter("@idkorisnika", ID));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Korisnik> ucitajKorisnike()
        {
            List<Korisnik> korisnici = new List<Korisnik>();
            string queryString =
                "SELECT * FROM T_Korisnik;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = queryString;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Korisnik kor;
                    while (reader.Read())
                    {
                        kor = new Korisnik();
                        kor.ID = Int32.Parse(reader["idkorisnika"].ToString());
                        kor.Ime = reader["Ime"].ToString();
                        kor.Prezime = reader["Prezime"].ToString();
                        kor.Adresa = reader["Adresa"].ToString();
                        korisnici.Add(kor);
                    }
                }
            }
            return korisnici;
        }
    }
}

