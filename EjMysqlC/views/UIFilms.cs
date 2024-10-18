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

namespace EjMysqlC.views
{
    public partial class UIFilms : Form
    {
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
    }
}
