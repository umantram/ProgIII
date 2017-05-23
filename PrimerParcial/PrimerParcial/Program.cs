using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {

            Pasajero pas1 = new Pasajero("Andres", 1);
            Pasajero pas2 = new Pasajero("Franco", 2);
            Pasajero pas3 = new Pasajero("Arcangel", 3);

            Tarjeta tar = new Tarjeta("aaa", 111);
            Paypal pay = new Paypal("uman");

            pas1.FormaPago(tar);
            pas3.FormaPago(pay);


            Empleado emp1 = new Empleado("Jorge", 4, 44, "barredor");

            Avion avion = new Avion();

            avion.VentaEconomico(pas1);
            avion.VentaEconomico(pas2);
            avion.VentaEjecutivo(emp1);
            avion.VentaEjecutivo(pas3);

            avion.ListadoDePasajeros();
            avion.ListadoDePagosPaypal();

            Console.ReadKey();

        }
    }
}
