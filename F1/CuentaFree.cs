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
    public partial class CuentaFree : Form
    {
        ClsCuentaFree cuentafre;

        public CuentaFree()
        {
            cuentafre = new ClsCuentaFree();
            InitializeComponent();

            TxtNombre.Text = cuentafre.Nombre;
            TxtNum.Text = cuentafre.NumCuenta;
            TxtSaldo.Text = Convert.ToString(cuentafre.Saldo);
        }

        private void CuentaFree_Load(object sender, EventArgs e)
        {

        }
        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            

        }

        private void BtnDepositar_Click_1(object sender, EventArgs e)
        {
            if (TxtCantDeposito.Text != "")
            {
                try
                {

                    cuentafre.Deposito(float.Parse(TxtCantDeposito.Text));
                    TxtSaldo.Text = Convert.ToString(cuentafre.Saldo);
                    TxtCantDeposito.Text = "";
                }
                catch
                {
                    MessageBox.Show("Ingresar solo numeros");
                    TxtCantDeposito.Text = "";
                }

            }
        }

        private void BtnRetirar_Click_1(object sender, EventArgs e)
        {
            if (TxtCantRetiro.Text != "")
            {
                try
                {
                    float saldo = float.Parse(TxtSaldo.Text);
                    float retiro = float.Parse(TxtCantRetiro.Text);
                    if (saldo > retiro)
                    {

                        cuentafre.Retiro(retiro);

                        TxtSaldo.Text = Convert.ToString(cuentafre.Saldo);
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
