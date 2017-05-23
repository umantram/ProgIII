using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcial
{
    class Paypal: IPago
    {
        public String Email { get; set; }
        public int PagoP { get; set; }

        public Paypal(String email) 
        {

            Email = email;

        }

        public void Pago(int p)
        {
            PagoP = p;
        }


    }
}
