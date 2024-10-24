using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjMysqlC.models;
namespace EjMysqlC.controllers
{
    internal class ControllerCustomer
    {
        internal BindingSource SelectCustomerAddres()
        {
            BindingSource consulta = null;
            string sql = "select concat(c.first_name,' ', c.last_name) as 'Name Customer', " +
                "c.email, a.address, a.district " +
                "from customer c " +
                "Join address a on c.address_id=a.address_id; ";
            Customer objCustomer=new Customer();
            consulta = objCustomer.SelectCustommerAdres(sql);

            return consulta;
        }
    }
}
