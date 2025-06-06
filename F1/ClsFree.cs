using System;

namespace F1
{
    class ClsCuentaFree : CLSCuenta
    {
        public ClsCuentaFree() :base()
        {
            nombre = "Cuenta free";
       }

        public override bool Deposito(float cantidad)
        {
            if (cantidad >= 1 && cantidad <= 10000 && saldo + cantidad <= 35000)
            {
                saldo = saldo + cantidad;
                return true;
            }
            return false;
        }

        public override bool Retiro(float cantidad)
        {
            if (cantidad > 1 && cantidad < 5000 && cantidad <= saldo)
            {
                saldo = saldo - cantidad;
                return true;
            }
            return false;
        }
    }    
}