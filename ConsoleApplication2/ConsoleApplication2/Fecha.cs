using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Fecha
    {

        private DateTime fecha = DateTime.Now;


        public DateTime Fecha1
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public override string ToString()
        {
            return fecha.ToString();
        }

        public string Entrefechas(DateTime fechaDesde, DateTime fechaHasta) 
        {

            return fechaDesde >= fe && dateToCheck < endDate;

        }
    }
}
