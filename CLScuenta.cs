using System;

namespace F1
{ 
abstract class CLSCuenta
{
        protected string nombre;
        protected string numCuenta;
        protected float saldo;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string NumCuenta
        {
            get { return numCuenta; }
            set { numCuenta = value; }
        }

        public float Saldo
        {
            get { return saldo; }
        }

        public CLSCuenta()
        {
            nombre = "";
            numCuenta = "0220";
            saldo = 10000;
        }

        abstract public bool Deposito(float cantidad);
        abstract public bool Retiro(float cantidad);
        public string Estado()
        {
            return "La cuenta : " + numCuenta + " pertenece a : " + nombre + " y tiene : $" + saldo;
        }

    }

}