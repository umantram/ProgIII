using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesyConstructores
{
    class Empleado
    {

        private string nombre;
        private int edad;

        public string Nombre {

            get { return nombre.ToUpper()};
            set { nombre = value};

        }

        public int Edad { 
            
            get { return edad;} 
            
            set {
                if (value > 150)
                    edad =120;
                else
                    edad=50;
                }
                
        }
    }

    class Gerente:Empleado{
    

    }
}
