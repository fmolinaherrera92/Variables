using System;

namespace DesicionesyBucles
{
    class Program
    {
        static void Main(string[] args)
        {
            //ComparaciondeUtilizandoBooleano();
            OperadorAnduOR();
        }

        public static void OperadorAnduOR() 
        {
            var cantidad = 6;

            var estaEntre5y10 = cantidad > 5 && cantidad < 10; // true
            Console.WriteLine($"Esta el {cantidad} entre 5 y 10? {estaEntre5y10}");

        }

        public static void ComparaciondeUtilizandoBooleano() 
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

            var cantidad1MenorOIgualQue10 = cantidad1 <= 10; // true
            var cantidad1MayorOIgualQue10 = cantidad1 >= 10; // false

            string nombre1 = null;
            var nombre2 = "Francisco";

            var sonLosNombresIguales = nombre1 == nombre2; // true

            var esNombre1Nulo = nombre1 is null; // false
            var esNombre1NoNulo = nombre1 is not null; // true
            Console.WriteLine("Es nombre 1  igual a nulo?" + esNombre1Nulo);
            Console.WriteLine("Es nombre 1  diferente de nulo?" + esNombre1NoNulo);
        }

    }
    }

