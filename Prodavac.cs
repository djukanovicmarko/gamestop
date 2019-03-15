using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace Domaci8_9_10
{
    [Serializable]
    class Prodavac
    {
        private int id;
        private string ime;
        private string prezime;
        private string sifra;

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
                    throw new Exception("Morate uneti ime prodavca!!!");
                ime = value;
            }
        }

        public string Prezime
        {
            get { return prezime; }
            set
            {
                if (value == "")
                    throw new Exception("Morate uneti prezime prodavca!!!");
                prezime = value;
            }
        }


        
        public string Sifra
        {
            get { return sifra; }
            set
            {
                if (value == "")
                    throw new Exception("Morate uneti sifru prodavca!!!");
                sifra = value;
            }
        }

        private string _connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Marko\\Desktop\\Domaci C#\\Domaci8-9-10\\Domaci8-9-10\\prodajaIgara.mdf;Integrated Security=True;User Instance=True";

        public void dodajProdavce()
        {
            string insertSql = "INSERT INTO T_Prodavac " +
                "(Ime, Prezime, Sifra) VALUES " +
                "(@Ime, @Prezime, @Sifra)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = insertSql;
                command.Parameters.Add(new SqlParameter("@Ime", Ime));
                command.Parameters.Add(new SqlParameter("@Prezime", Prezime));
                command.Parameters.Add(new SqlParameter("@Sifra", Sifra));
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void azurirajProdavce()
        {
            string updateSql =
                "UPDATE T_Prodavac " +
                "SET Ime= @Ime, Prezime = @Prezime, Sifra = @Sifra " +
                "WHERE idprodavca = @idprodavca;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = updateSql;
                command.Parameters.Add(new SqlParameter("@idprodavca", ID));
                command.Parameters.Add(new SqlParameter("@Ime", Ime));
                command.Parameters.Add(new SqlParameter("@Prezime", Prezime));
                command.Parameters.Add(new SqlParameter("@Sifra", Sifra));
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void obrisiProdavce()
        {
            string deleteSql =
                "DELETE FROM T_Prodavac WHERE idprodavca = @idprodavca;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = deleteSql;
                command.Parameters.Add(new SqlParameter("@idprodavca", ID));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Prodavac> ucitajProdavce()
        {
            List<Prodavac> prodavci = new List<Prodavac>();
            string queryString =
                "SELECT * FROM T_Prodavac;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = queryString;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Prodavac prod;
                    while (reader.Read())
                    {
                        prod = new Prodavac();
                        prod.ID = Int32.Parse(reader["idprodavca"].ToString());
                        prod.Ime = reader["Ime"].ToString();
                        prod.Prezime = reader["Prezime"].ToString();
                        prod.sifra = reader["Sifra"].ToString();
                        prodavci.Add(prod);
                    }
                }
            }
            return prodavci;
        }
    }
}
