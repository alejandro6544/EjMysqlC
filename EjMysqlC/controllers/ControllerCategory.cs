using EjMysqlC.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjMysqlC.models;

namespace EjMysqlC.controllers
{
    class ControllerCategory
    {
        internal bool InsertCategory(Category objc)
        {
            bool result = false;

            string sql = "insert into category (name) values('" + objc.Name + "');";
            ConnectionBD objBD = new ConnectionBD();
            result = objBD.ExecuteQuery(sql);

            return result;

        }

        internal List<Category> ShowCategoriesC()
        {
            List<Category> listac = null;
            string sql = "Select * from category;";
            Category objC = new Category();
            listac = objC.SelectCategories(sql);

            return listac;
        }

        internal bool UpDateCategory(string nameCategory, int id_category)
        {
            bool result=false;

            string sql = "update category set name='"+ nameCategory+ "' where category_id="+ id_category;
            ConnectionBD objBD = new ConnectionBD();
            result = objBD.ExecuteQuery(sql);
            return result;
        }
    }
}
