using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesicionesyBucles
{
    class OperadorAnduOR
    {
        public void OperadorAnduOR1()
        {
            var cantidad1 = 5;
            //var cantidad2 = 5;
            var cantidad = 7;

            // true && true => true
            // true && false => false 
            // false && true => false 
            // false && false => false 
            var estaEntre5y10 = cantidad > 5 && cantidad < 10; // true
            Console.WriteLine($"Esta el {cantidad} entre 5 y 10? {estaEntre5y10}");


            // true || true => true
            // true || false => true
            // false || true => true
            // false || false => false
            var cantidad1Es5o6 = cantidad1 == 5 || cantidad1 == 6; // true

            Console.WriteLine($"¿Es {cantidad1} igual a 5 o 6? {cantidad1Es5o6}");

            string apellido = "Frais";

            var estaElApellidoEnMayusculas = apellido is not null && apellido == apellido.ToUpper();

            Console.WriteLine("Está el string en mayúsculas? " + estaElApellidoEnMayusculas);
        }
    }
}
