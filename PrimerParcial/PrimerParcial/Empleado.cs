using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcial
{
    class Empleado: Pasajero
    {

        public int Credencial { get; set; }
        public String Funcion { get; set; }

        public Empleado(String NyAp, int dni, int Cred, String Func) : base(NyAp, dni) 
        {
            Credencial = Cred;
            Funcion = Func;
        }


    }
}
