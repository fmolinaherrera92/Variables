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
            var cantidad = 5;

            if (cantidad.ToString() == "5")
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son Diferentes");
            }
        }
    }
}
