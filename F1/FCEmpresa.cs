using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1
{
    public partial class FCEmpresa : Form
    {
        ClsEmpresa empresa;
        public FCEmpresa()
        {
            empresa = new ClsEmpresa();
            InitializeComponent();

            TxtNombre.Text = empresa.Nombre;
            TxtNum.Text = empresa.NumCuenta;
            TxtSaldo.Text = Convert.ToString(empresa.Saldo);
        }

        private void FCEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            if (TxtCantDeposito.Text != "")
            {
                try
                {

                    empresa.Deposito(float.Parse(TxtCantDeposito.Text));
                    TxtSaldo.Text = Convert.ToString(empresa.Saldo);
                    TxtCantDeposito.Text = "";
                }
                catch
                {
                    MessageBox.Show("Ingresar solo numeros");
                    TxtCantDeposito.Text = "";
                }

            }
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            if (TxtCantRetiro.Text != "")
            {
                try
                {
                    float saldo = float.Parse(TxtSaldo.Text);
                    float retiro = float.Parse(TxtCantRetiro.Text);
                    if (saldo > retiro)
                    {

                        empresa.Retiro(retiro);

                        TxtSaldo.Text = Convert.ToString(empresa.Saldo);
                        TxtCantRetiro.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente");
                    }

                }
                catch
                {
                    MessageBox.Show("Ingresar solo numeros");
                    TxtCantDeposito.Text = "";
                }

            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
