using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesicionesyBucles
{
    class ComparaciondeUtilizandoBooleano
    {
        public  void ComparaciondeUtilizandoBooleano1()
        {
            var cantidad1 = 5;
            var cantidad2 = 5;
            //Comparacion de utilizando booleano
            var cantidad1IgualCantidad2 = cantidad1 == cantidad2; // true

            var cantidad1esDiferenteACantidad2 = cantidad1 != cantidad2; // false

            Console.WriteLine($"son {cantidad1} y {cantidad2} iguales?{cantidad1IgualCantidad2}");
            Console.WriteLine($"son {cantidad1} y {cantidad2} es diferente? {cantidad1esDiferenteACantidad2}");

            var cantidad1MenorQue10 = cantidad1 < 10; // true
            var cantidad1MayorQue10 = cantidad1 > 10; // false
            Console.WriteLine(cantidad1MenorQue10);
            Console.WriteLine(cantidad1MayorQue10);


            var cantidad1MenorOIgualQue10 = cantidad1 <= 10; // true
            var cantidad1MayorOIgualQue10 = cantidad1 >= 10; // false

            Console.WriteLine(cantidad1MenorOIgualQue10);
            Console.WriteLine(cantidad1MayorOIgualQue10);
            string nombre1 = null;
            var nombre2 = "Francisco";

            var sonLosNombresIguales = nombre1 == nombre2; // true
            Console.WriteLine(sonLosNombresIguales);
            Console.WriteLine(sonLosNombresIguales);

            var esNombre1Nulo = nombre1 is null; // false
            var esNombre1NoNulo = nombre1 is not null; // true
            Console.WriteLine("Es nombre 1  igual a nulo?" + esNombre1Nulo);
            Console.WriteLine("Es nombre 1  diferente de nulo?" + esNombre1NoNulo);
        }

    }
}
