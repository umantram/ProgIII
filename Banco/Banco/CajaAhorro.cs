using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    class CajaAhorro:Cuenta
    {
        CajaAhorro(int NumCta, int Mto, String Tit)
        {
            NumCuenta = NumCta;
            Monto = Mto;
            Titular = Tit;
        
        }

        public void Extraer(int valor) { 
            
            
        }

        override 
    }
}
