using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcial
{
    class Pasajero
    {

        public String NombreyApellido { get; set; }
        public int DNI { get; set; }
        public IPago Pago { get; set; }

        public Pasajero(String NyAp, int dni) 
        {
            NombreyApellido = NyAp;
            DNI = dni;
        }

        public void FormaPago(IPago pago) 
        {
            Pago = pago;
        }

    }
}
