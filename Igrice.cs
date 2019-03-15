using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Domaci8_9_10
{
     [Serializable]
    class Igrice
    {
        private int id;
        private string naziv;
        private string sifra;
        private string tip;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Naziv
        {
            get { return naziv; }
            set
            {
                if (value == "")
                    throw new Exception("Morate uneti naziv igrice!!!");
                naziv = value;
            }
        }

        public string Sifra
        {
            get { return sifra; }
            set
            {
                if (value == "")
                    throw new Exception("Morate uneti šifru igrice!!!");
                sifra = value;
            }
        }

        public string Tip
        {
            get { return tip; }
            set
            {
                if (value == "")
                    throw new Exception("Morate uneti tip igrice!!!");
                tip = value;
            }
        }

        private string _connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Marko\\Desktop\\Domaci C#\\Domaci8-9-10\\Domaci8-9-10\\prodajaIgara.mdf;Integrated Security=True;User Instance=True";

        public void dodajIgrice()
        {
            string insertSql = "INSERT INTO T_Igrice " +
                "(Naziv, Sifra, Tip) VALUES " +
                "(@Naziv, @Sifra, @Tip)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = insertSql;
                command.Parameters.Add(new SqlParameter("@Naziv", Naziv));
                command.Parameters.Add(new SqlParameter("@Sifra", Sifra));
                command.Parameters.Add(new SqlParameter("@Tip", Tip));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void azurirajIgrice()
        {
            string updateSql =
                "UPDATE T_Igrice " +
                "SET Naziv = @Naziv, Sifra = @Sifra, Tip = @Tip " +
                "WHERE idigrice = @idigrice;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = updateSql;
                command.Parameters.Add(new SqlParameter("@idigrice", ID));
                command.Parameters.Add(new SqlParameter("@Naziv", Naziv));
                command.Parameters.Add(new SqlParameter("@Sifra", Sifra));
                command.Parameters.Add(new SqlParameter("@Tip", Tip));
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void obrisiIgrice()
        {
            string deleteSql =
                "DELETE FROM T_Igrice WHERE idigrice = @idigrice;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = deleteSql;
                command.Parameters.Add(new SqlParameter("@idigrice", ID));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Igrice> ucitajIgrice()
        {
            List<Igrice> igrice = new List<Igrice>();
            string queryString =
                "SELECT * FROM T_Igrice;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = queryString;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Igrice igre;
                    while (reader.Read())
                    {
                        igre = new Igrice();
                        igre.ID = Int32.Parse(reader["idigrice"].ToString());
                        igre.Naziv = reader["Naziv"].ToString();
                        igre.Sifra = reader["Sifra"].ToString();
                        igre.Tip = reader["Tip"].ToString();
                        igrice.Add(igre);
                    }
                }
            }
            return igrice;
        }

    }
}

