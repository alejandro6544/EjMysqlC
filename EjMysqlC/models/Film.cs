using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjMysqlC.models
{
    class Film
    {
        private int film_id;
        private string titulo;
        private int language_id;
        private int rental_duration;
        private double rental_rate;
        private double replacement_cost;
        private string last_update;

        public Film()
        {
        }

        public Film(int film_id, string titulo, int language_id, int rental_duration, double rental_rate, double replacement_cost, string last_update)
        {
            this.film_id = film_id;
            this.titulo = titulo;
            this.language_id = language_id;
            this.rental_duration = rental_duration;
            this.rental_rate = rental_rate;
            this.replacement_cost = replacement_cost;
            this.last_update = last_update;
        }

        public Film(int film_id, string titulo, string last_update)
        {
            this.film_id = film_id;
            this.titulo = titulo;
            this.last_update = last_update;
        }

        public int Film_id { get => film_id; set => film_id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Language_id { get => language_id; set => language_id = value; }
        public int Rental_duration { get => rental_duration; set => rental_duration = value; }
        public double Rental_rate { get => rental_rate; set => rental_rate = value; }
        public double Replacement_cost { get => replacement_cost; set => replacement_cost = value; }
        public string Last_update { get => last_update; set => last_update = value; }
    }
}
