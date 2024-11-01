using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjMysqlC.controllers;
using EjMysqlC.models;

namespace EjMysqlC.views
{
    public partial class UILogin : Form
    {
        public UILogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usern = textBox1.Text;
            string pass = textBox2.Text;

            ControllerStaff objCS = new ControllerStaff();
            bool result = objCS.SelectUser(usern, pass);

            if (result)
            {
                // MessageBox.Show("Usuario encontrado");

                if (usern.Equals("dacastro"))
                {
                    UIAdmin objUA = new UIAdmin();
                    objUA.Show();
                    this.Hide();
                } else if (usern.Equals("abenavides"))
                {
                    UIUser objU = new UIUser();
                    objU.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }
    }
}
