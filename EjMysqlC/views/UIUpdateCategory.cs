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
    public partial class UIUpdateCategory : Form
    {
        List<Category> listaCategorias;
        string nameComparate;
        public UIUpdateCategory()
        {
            InitializeComponent();
        }

        private void SelectCategoryU(object sender, EventArgs e)
        {
            ControllerCategory objCC = new ControllerCategory();

           listaCategorias = objCC.ShowCategoriesC();

            for (int i = 0; i < listaCategorias.Count; i++)
            {
                comboBox1.Items.Add(listaCategorias[i].Name);

            }
        }

        private void SelectItem(object sender, EventArgs e)
        {
           textBox2.Text = comboBox1.GetItemText(this.comboBox1.SelectedItem.ToString());
            nameComparate= comboBox1.GetItemText(this.comboBox1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameCategory = textBox2.Text;
            int id_category = 0;

            for(int i = 0; i < listaCategorias.Count; i++)
            {
                if (listaCategorias[i].Name.Equals(nameComparate))
                {
                    id_category = listaCategorias[i].Category_id;
                }

            }
            ControllerCategory objCC = new ControllerCategory();
            bool resultado = objCC.UpDateCategory(nameCategory, id_category);

            if (resultado)
            {
                MessageBox.Show("Si se realizó la modificación");
            }
            else
            {
                MessageBox.Show("No se realizó la modificación");
            }
        }
    }
}
