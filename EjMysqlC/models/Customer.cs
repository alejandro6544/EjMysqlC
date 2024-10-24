using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjMysqlC.models
{
    internal class Customer
    {
        ConnectionBD objConection = new ConnectionBD();
        internal BindingSource SelectCustommerAdres(string sql)
        {
            BindingSource consulta=new BindingSource();

            
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, objConection.DataSource());
                objConection.ConnectOpened();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                consulta.DataSource = dt;

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


            return consulta;
        }
    }
}
