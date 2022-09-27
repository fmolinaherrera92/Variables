using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Variables
{
    class Fecha
    {
        public void CodigoDelCurso()
        {
            
            DateTime ahora = DateTime.Now;
            DateTime primerDiaDelAño = new DateTime(2022, 1, 1, 7, 15, 23);
            DateTime mañana = DateTime.Now.AddDays(1);

            Console.WriteLine(ahora);
            Console.WriteLine(primerDiaDelAño);
            Console.WriteLine(mañana);

            Console.WriteLine($"El dia es:{mañana.Day}");
            
            Console.WriteLine($"El dia del año es:{mañana.DayOfYear}");
          
            Console.WriteLine($"El dia de la semana es:{mañana.DayOfWeek}");
          


        }
    }
}
