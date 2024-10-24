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
using Google.Protobuf.Collections;

namespace EjMysqlC.views
{
    public partial class UIConsultas : Form
    {
        public UIConsultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControllerCustomer objeCC = new ControllerCustomer();
            BindingSource consulta = objeCC.SelectCustomerAddres();
            dataGridView1.DataSource = consulta;
        }
    }
}
