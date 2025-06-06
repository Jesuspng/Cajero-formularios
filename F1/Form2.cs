using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using F1;


namespace F1
{
    
    public partial class Form2 : Form
    {
        private ClsCuentaJR cuentajr;
        public Form2()
        {
            cuentajr = new ClsCuentaJR();
            InitializeComponent();

            TxtNombre.Text = cuentajr.Nombre;
            TxtNum.Text = cuentajr.NumCuenta;
            TxtSaldo.Text =Convert.ToString(cuentajr.Saldo);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            if (TxtCantDeposito.Text != "")
            {
                try
                {

                cuentajr.Deposito(float.Parse(TxtCantDeposito.Text));
                TxtSaldo.Text =Convert.ToString(cuentajr.Saldo);
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
                        
                        cuentajr.Retiro(retiro);
                      
                        TxtSaldo.Text = Convert.ToString(cuentajr.Saldo);
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
