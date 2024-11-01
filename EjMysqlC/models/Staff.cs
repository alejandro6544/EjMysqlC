using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EjMysqlC.models
{
    class Staff
    {
        ConnectionBD objConection = new ConnectionBD();
        internal bool SelectUser(string sql, string pass)
        {
            bool result = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, objConection.DataSource());
                objConection.ConnectOpened();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int staff_id = reader.GetInt32(0);
                        string password = reader.GetString(1);

                        if (password.Equals(pass))
                        {
                            result = true;
                        }


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

            return result;

        }
    }
}
