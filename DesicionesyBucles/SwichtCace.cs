using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesicionesyBucles
{
    class SwichtCace2
    {
        public void suchicase()
        {
            var lugar = 4;

            switch (lugar)
            {
                case 1:
                    Console.WriteLine("¡Quedaste en primer lugar!");
                    break;
                case 2:
                    Console.WriteLine("¡Quedaste en segundo lugar!");
                    break;
                case 3:
                    Console.WriteLine("¡Puedes vender tu medalla de bronce en una compraventa!");
                    break;
                case 4:
                    Console.WriteLine("Casi casi lo lograste");
                    break;

                default:
                    Console.WriteLine("¡Mejor suerte para la próxima!");
                    break;

            }


        }

        public void PatronRelacionado()
        {
            var temperatura = 35;

            var mensaje = temperatura switch
            {
                37 => "No tienes Ninguna Condicion",
                > 37 => "Tienes Fiebre",
                < 37 => "Puedes que Tengas baja el Azucar",
            };

            Console.WriteLine(mensaje);
        }

        public void Buclewhile()
        {
            int Contadator = 1;

            while (Contadator <= 10)
            {
                Console.WriteLine(Contadator);
                Contadator++;
            }

            var balance = 200m;
            var interes = 1.07m;
            var contadorInteres = 1;

            while (contadorInteres <= 10)
            {
                balance *= interes;
                contadorInteres++;


            }
            Console.WriteLine(balance);
        }
        public void BucleDowhile()
        {
            int Contadator = 1;
            do
            {
                Console.WriteLine(Contadator);
                Contadator++;
            } while (Contadator <= 10);
        }

        public void BucleFor()
        {
            //for (int contador = 0; contador <= 10; contador = contador + 2)
            //{
            //    Console.WriteLine(contador);
            //}
            var n = 30;
            for (int i = 0; i <= n; i++)
            {
                if (i % 3 ==0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0 )
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");

                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            for (int i = 1; i <= 10 ; i++)
            {
                if (i == 5)
                {
                   // break;
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public void BucleForEach()
        {
            var nombre = "Francisco";
            foreach (var Letra  in nombre)
            {
                Console.WriteLine(Letra);
            }
        }
    }
}
