using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace libros
{
    class Biblioteca
    {

        ArrayList libros;

        public Biblioteca(Libro libro) 
        {

            libros.Add(libro);

        }

        public override string ToString()
        {
            return base.ToString();

            foreach (Libro item in libros)
            {

                Console.WriteLine(item);

            }
        }
  
    }
}
