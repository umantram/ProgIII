using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encriptacion
{
    class Program
    {

        static void Main(string[] args)
        {

            string encrip; //= encrip.ToCharArray();

            encrip = "Mb fcyb dhrqb zbFgéñégr yñ dhRégñ, gi rérf ehüra yñ gÜrar ehr ñgéñjrFñé. Üvxaéalaosevélv vjvk vd vdvyaüg.";

            char[] valores = encrip.ToCharArray();

            String nuevo = "";

            int i = 0;

            byte b = 0;

            //byte sumador = 17;

            for (i=0;i<valores.Length;i++){

                //Console.WriteLine("{0}",encrip.Substring( i,1));

            
            for(byte a = 33; a<=126; a++)
            {
                //Console.WriteLine((char)a);
                if (valores[i] == (char)a)
                {
                    b = a++;

                    nuevo += (char)a  + " ";    
                }
                

            }

            }
            
            Console.WriteLine(nuevo);

            //String nuevo2="";

            /*
            for (byte a = 33; a <= 126; a++)
            {

                nuevo2 += (char)a + " ";    
                
            }

            Console.WriteLine(nuevo2);
            */

            Console.ReadKey();

            foreach (char item in encrip)
            {
                
            }

        }
    }
}
