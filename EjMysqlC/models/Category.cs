using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjMysqlC.models
{
    class Category
    {
        private int category_id;
        private string name;
        private string last_update;
        ConnectionBD objConection = new ConnectionBD();
        public Category()
        {
        }

        public Category(int category_id, string name, string last_update)
        {
            this.category_id = category_id;
            this.name = name;
            this.last_update = last_update;
        }

        public Category(int category_id, string name)
        {
            this.category_id = category_id;
            this.name = name;
        }

        public Category(string name)
        {
            this.name = name;
        }

        public int Category_id { get => category_id; set => category_id = value; }
        public string Name { get => name; set => name = value; }
        public string Last_update { get => last_update; set => last_update = value; }

        internal List<Category> SelectCategories(string sql)
        {
            List<Category> listaC = new List<Category>();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, objConection.DataSource());
                objConection.ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int cID = reader.GetInt32(0);
                        string nameC = reader.GetString(1);
                        listaC.Add(new Category(cID, nameC));

                    }
                }


            }
            catch (Exception w)
            {
                Console.WriteLine("ERROOOOOOR " + w.Message);
                objConection.ConnectClosed();
            }
            finally
            {
                objConection.ConnectClosed();
            }


            return listaC;
        }
    }
}
