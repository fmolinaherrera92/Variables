using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos
{
    class Arreglos
    {
        public void Array() 
        {

            char[] Vocales = new char[5] { 'a', 'e', 'i', 'o', 'u', };


            var segundaVocal = Vocales[1];

            var ultimaVocal = Vocales [^1];

            Index Penultima = ^2;
            var penultimaVocal = Vocales[Penultima];

            Console.WriteLine(penultimaVocal);

            // Console.WriteLine(segundaVocal); //e

            //var unaVocalMagica = Vocales[5]; // no hay existe ese elemento en el arreglo 

            //foreach (var vocal in Vocales)
            //{
            //    Console.WriteLine(vocal);
            //}

            // Arreglos 2: Arreglos de enteros

            //var Primeros6Numeros = new int[] { 1, 2, 3, 4, 5 ,6};

            //foreach (var numeros in Primeros6Numeros)
            //{
            //    Console.Write($"{numeros} ");
            //}

            //Primeros6Numeros[0] = 1;
            //Primeros6Numeros[1] = 2;
        }


    
    }
}
            