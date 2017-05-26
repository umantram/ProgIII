using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    abstract class Cuenta
    {
        public int NumCuenta { get; set; }
        public int Monto { get; set; }
        public String Titular { get; set; }

        abstract void Extraer() { }

        abstract void Depositar() { }



    }
}
