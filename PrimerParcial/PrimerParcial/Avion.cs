using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimerParcial
{
    class Avion
    {

        //public List<Pasajero> Ejecutivos { get; set; }
        //public List<Pasajero> Economicas { get; set; }

        List<Pasajero> Ejecutivos = new List<Pasajero>();
        List<Pasajero> Economicas = new List<Pasajero>();

        public void VentaEjecutivo(Pasajero pas) 
        {
            Ejecutivos.Add(pas);
        }

        public void VentaEconomico(Pasajero pas) 
        {
            Economicas.Add(pas);
        }

        public void ListadoDePasajeros() 
        {
            foreach (Pasajero item in Ejecutivos)
            {
                Console.WriteLine("Ejecutivos: {0} ", item.NombreyApellido);
            }

            foreach (Pasajero item in Economicas)
            {
                Console.WriteLine("Economicas: {0} ", item.NombreyApellido);
            }

        }

        public void ListadoDePagosPaypal() 
        {
            foreach (Pasajero item in Ejecutivos)
            {
                if (item.Pago != null) 
                {

                    if (item.Pago.GetType() == Type.GetType("PrimerParcial.Paypal"))
                    {
                        Console.WriteLine("-----: {0}", item.Pago);    
                        
                    }
                    //Console.WriteLine("-----: {0}", item.Pago.GetType());    
                    //Console.WriteLine("PagoEj: {0}", item.Pago);    
                }
                
            }

            foreach (Pasajero item in Economicas)
            {
                Console.WriteLine("PagoEcon: {0}", item.Pago);
            }

        }

    }
}
