using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1
{
    internal class ClsEmpresa:CLSCuenta
    {
        public ClsEmpresa() : base()
        {
            nombre = "Cuenta Empresarial";
        }

        public override bool Deposito(float cantidad)
        {
            if (cantidad >= 1 && cantidad <= 5000 && saldo + cantidad <= 35000)
            {
                saldo = saldo + cantidad-50;
                return true;
            }
            return false;
        }

        public override bool Retiro(float cantidad)
        {
            if (cantidad > 1 && cantidad <= saldo+50)
            {
                saldo = saldo - (cantidad+50);
                return true;
            }
            return false;
        }
    }
}
