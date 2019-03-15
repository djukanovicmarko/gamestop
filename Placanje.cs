using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Domaci8_9_10
{
    [Serializable]
    class Placanje
    {
        private int id;
        private string nacinPlacanja;
        private DateTime datum;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string NacinPlacanja
        {
            get { return nacinPlacanja; }
            set
            {
                if (value == "")
                    throw new Exception("Morate uneti nacin placanja!!!");
                nacinPlacanja = value;
            }
        }

        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }

        private string _connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\Marko\\Desktop\\Domaci C#\\Domaci8-9-10\\Domaci8-9-10\\prodajaIgara.mdf;Integrated Security=True;User Instance=True";

        public void dodajPlacanje()
        {
            string insertSql = "INSERT INTO T_Placanje " +
                "(nacinPlacanja, Datum) VALUES (@nacinPlacanja, @Datum)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = insertSql;
                command.Parameters.Add(new SqlParameter("@nacinPlacanja", NacinPlacanja));
                command.Parameters.Add(new SqlParameter("@Datum", Datum));
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void azurirajPlacanje()
        {
            string updateSql =
                "UPDATE T_Placanje " +
                "SET Nacin = @nacinPlacanja, Datum = @Datum " +
                "WHERE idplacanja = @idplacanja";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = updateSql;
                command.Parameters.Add(new SqlParameter("@idplacanja", ID));
                command.Parameters.Add(new SqlParameter("@nacinPlacanja", NacinPlacanja));
                command.Parameters.Add(new SqlParameter("@Datum", Datum));
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void obrisiPlacanje()
        {
            string deleteSql =
                "DELETE FROM T_Placanje WHERE idplacanja = @idplacanja;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = deleteSql;
                command.Parameters.Add(new SqlParameter("@idplacanja", ID));
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Placanje> ucitajPlacanje()
        {
            List<Placanje> placanja = new List<Placanje>();
            string queryString =
                "SELECT * FROM T_Placanje;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = queryString;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Placanje plat;
                    while (reader.Read())
                    {
                        plat = new Placanje();
                        plat.ID = Int32.Parse(reader["idplacanja"].ToString());
                        plat.nacinPlacanja = reader["nacinPlacanja"].ToString();
                        plat.Datum = DateTime.Parse(reader["Datum"].ToString());
                        placanja.Add(plat);
                    }
                }
            }
            return placanja;
        }
    }
}
