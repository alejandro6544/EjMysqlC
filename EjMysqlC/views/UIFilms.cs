using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjMysqlC.models;
using EjMysqlC.controllers;
using System.Globalization;

namespace EjMysqlC.views
{
    public partial class UIFilms : Form
    {
        string rutaImagen;
        public UIFilms()
        {
            InitializeComponent();
        }

        private void ShowCategories(object sender, EventArgs e)
        {
            ControllerCategory objCC = new ControllerCategory();

            List<Category> listaCategorias = objCC.ShowCategoriesC();

            for (int i = 0; i < listaCategorias.Count; i++)
            {
                comboBox1.Items.Add(listaCategorias[i].Name);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = textBox1.Text;
            int language_id = 2;
            int rental_duration = Int32.Parse(textBox2.Text);
            double numeroDouble=double.Parse(textBox3.Text);
            string rental_rate = numeroDouble.ToString(CultureInfo.InvariantCulture);

            double numeroDouble2 = double.Parse(textBox4.Text);
            string replacement_cost = numeroDouble2.ToString(CultureInfo.InvariantCulture);

            Film objF=new Film(titulo, language_id, rental_duration, rental_rate, replacement_cost, rutaImagen);
            ControllerFilmcs objCF=new ControllerFilmcs();
            bool resultado= objCF.InsertFilm(objF);

            if(resultado) 
            {
                MessageBox.Show("Se inserto");
            }
            else 
            {
                MessageBox.Show("No se inserto");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rutaImagen = openFileDialog1.FileName;
                    Console.WriteLine("Name file " + openFileDialog1.FileName);
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
