using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcial
{
    class Tarjeta: IPago
    {

        public String Nombre { get; set; }
        public int Numero { get; set; }
        public int PagoT { get; set; }

        public Tarjeta(String nom, int num) 
        {

            Nombre = nom;
            Numero = num;
            
        }


        public void Pago(int p)
        {
            PagoT = p;
        }

    }
}
