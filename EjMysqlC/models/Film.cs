using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjMysqlC.models
{
    class Film
    {
        private int film_id;
        private string title;
        private int language_id;
        private int rental_duration;
        private string rental_rate;
        private string replacement_cost;
        private string afichefilm;

        ConnectionBD connection=new ConnectionBD();

        public Film()
        {
        }

        public Film(int film_id, string title, int language_id, int rental_duration, string rental_rate, string replacement_cost)
        {
            this.film_id = film_id;
            this.title = title;
            this.language_id = language_id;
            this.rental_duration = rental_duration;
            this.rental_rate = rental_rate;
            this.replacement_cost = replacement_cost;
        }

        public Film(string title, int language_id, int rental_duration, string rental_rate, string replacement_cost, string afichefilm)
        {
            this.title = title;
            this.language_id = language_id;
            this.rental_duration = rental_duration;
            this.rental_rate = rental_rate;
            this.replacement_cost = replacement_cost;
            this.afichefilm = afichefilm;
        }

        public string Title { get => title; set => title = value; }
        public int Language_id { get => language_id; set => language_id = value; }
        public int Rental_duration { get => rental_duration; set => rental_duration = value; }
        public string Rental_rate { get => rental_rate; set => rental_rate = value; }
        public string Replacement_cost { get => replacement_cost; set => replacement_cost = value; }
        public int Film_id { get => film_id; set => film_id = value; }
        public string Afichefilm { get => afichefilm; set => afichefilm = value; }

        internal bool ExecuteQueryImage(string sql, string afichefilm)
        {
            bool result = false;
            FileStream fs;
            BinaryReader br;
            try
            {
                byte[] ImageData;
                fs = new FileStream(afichefilm, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();

                MySqlCommand cmd = new MySqlCommand(sql, connection.DataSource());
                //ConnectOpened();
                cmd = new MySqlCommand(sql, connection.DataSource());
                cmd.Parameters.Add("@afichefilm", MySqlDbType.LongBlob);
                cmd.Parameters["@afichefilm"].Value = ImageData;

                connection.ConnectOpened();
                int RowsAffected = cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    result = true;

                }

            }
            catch (Exception w)
            {
                Console.WriteLine("ERROOOOOOR " + w.Message);

                connection.ConnectClosed();
            }
            finally
            {
                connection.ConnectClosed();
            }
            return result;
        }
    }
}
