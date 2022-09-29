using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos
{
    class Tostriing
    {
        public void ToStrIng()
        {
            /**
            var cantidad = 5;

            if (cantidad.ToString() == "5")
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son Diferentes");
            }**/

            var hoy = DateTime.Today.ToString("dd-MMM-yyyy");
            Console.WriteLine(hoy);
        }

        public void ToStrIngTryParse()
        {

            //// Ejemplo 1: Enteros
            //var CantidadString = "5";

            //int cantidad = int.Parse(CantidadString);

            //cantidad++;

            //Console.WriteLine(  cantidad);

            //// Ejemplo 2: Decimal
            //var CantidadDecimalString = "4.9";

            //var CantidadDecimal = decimal.Parse(CantidadDecimalString);

            //CantidadDecimal++;

            //Console.WriteLine(CantidadDecimal);

            //// Ejemplo 3: Booleanos

            //var BooleanoString = "True";

            //var booleanos = bool.Parse(BooleanoString);

            //if (booleanos)
            //{
            //    Console.WriteLine("Convertimos de string a booleano");
            //}

            //// Ejemplo 4: Fechas

            //var fechaString = "2022-05-09";

            //var fecha = DateTime.Parse(fechaString);
            //Console.WriteLine(fecha.AddYears(1));// 2023-05-09


            var supuestoNumero = "Francisco";
            // Lanza un error
            //var numero = int.Parse(supuestoNumero);

            int numero;

            var pudoParsear = int.TryParse(supuestoNumero, out numero);

            if (pudoParsear)
            {
                numero++;
                Console.WriteLine(numero);

            }
            else
            {
                Console.WriteLine($"el Valor {supuestoNumero} no tiene el valor correcto. ");
            }

            

        }
    }
}
