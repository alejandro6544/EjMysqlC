using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjMysqlC.models;

namespace EjMysqlC.controllers
{
    internal class ControllerFilmcs
    {
        internal bool InsertFilm(Film objF)
        {
            bool resultado = false;
            string sql = "insert into film (title, language_id, rental_duration, rental_rate, replacement_cost, afichefilm) " +
                "values ('"+objF.Title+"', "+objF.Language_id+", "+objF.Rental_duration+", "+objF.Rental_rate+
                ", "+objF.Replacement_cost+ ", @afichefilm);";

            //ConnectionBD objCDB = new ConnectionBD();
            Film objFF= new Film();
            resultado = objFF.ExecuteQueryImage(sql, objF.Afichefilm);
            //resultado = objCDB.ExecuteQuery(sql);
            return resultado;
        }
    }
}
