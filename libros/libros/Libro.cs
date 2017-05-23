using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libros
{
    class Libro:IComparable, IColeccionable
    {

        string autor;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public Libro() {


    
        }



        string IColeccionable.titulo
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Describir()
        {
            throw new NotImplementedException();
        }
    }
}
