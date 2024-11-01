using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjMysqlC.models;

namespace EjMysqlC.controllers
{
    class ControllerStaff
    {
        internal bool SelectUser(string usern, string pass)
        {
            bool result = false;

            string sql = "select staff_id, password from staff where username='"+ usern+"';";
            Staff objs = new Staff();

            result = objs.SelectUser(sql, pass);


            return result;
        }
    }
}
