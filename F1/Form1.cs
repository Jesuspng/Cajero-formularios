using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace F1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void BtnJr_Click(object sender, EventArgs e)
        {

        }

        private void BtnJr_Click_1(object sender, EventArgs e)
        {
            Form2 FormJr = new Form2();
            FormJr.Show();
        }

        private void BrnFree_Click(object sender, EventArgs e)
        {
            CuentaFree CuentaFree = new CuentaFree();
            CuentaFree.Show();
        }

        private void BtnEmpresa_Click(object sender, EventArgs e)
        {
            FCEmpresa ceuntaempresa = new FCEmpresa();
            ceuntaempresa.Show();
        }
    }
}
