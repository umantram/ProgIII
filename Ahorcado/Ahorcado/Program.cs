using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {

            String ahorcadopalabras = new AhorcadoPalabras.GeneradorPalabras().SiguientePalabra;
            char palabra;
            String palabrafinal = "";
            String encontro = "No";
            String temp = "";

            Console.WriteLine(ahorcadopalabras);
            foreach (char item in ahorcadopalabras)
            {
                Console.Write("_ ");
            }

            Console.WriteLine("Ingrese Letra");
            palabra = char.Parse(Console.ReadLine());

            //int cont = ahorcadopalabras.Length;

            int cont = 6;

            while (cont != 0 || palabrafinal == ahorcadopalabras)
            {

                palabrafinal = "";


                /*
                foreach (char buscar in ahorcadopalabras)
                {

                    if (palabra == buscar)
                    {

                        encontro = "Si";
                        palabrafinal = palabrafinal + palabra;
                        
                    }
                    else
                    {
                        palabrafinal = palabrafinal + "_ ";
                    }

                }
                */

                if (encontro == "No")
                {

                    Console.WriteLine("Error!!");
                    cont = -1;
                    Console.WriteLine(temp);

                }
                else if (encontro == "Si")
                {

                    Console.WriteLine(palabrafinal);

                }

                temp = palabrafinal;
                
                encontro = "No";

                Console.WriteLine("Ingrese Letra");
                palabra = char.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("Finn");
            Console.WriteLine(ahorcadopalabras);

   

            Console.ReadKey();





        }
    }
}
