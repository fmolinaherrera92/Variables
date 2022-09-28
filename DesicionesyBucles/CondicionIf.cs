using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesicionesyBucles
{
    class CondicionIf
    {
        public  void CondidionIF()
        {
            var cantidad1 = 9;

            if (cantidad1 > 5)
            {
                Console.WriteLine("Es Mayor que 5");
            }
            else if (cantidad1 == 3)
            {
                Console.WriteLine("El Valor es 3");

            }
            else
            {
                Console.WriteLine("Es Menor o igual a 5");

            }
        }

        public void Ternario() 
        {
            bool usuarioEstaLogueado = true;

            string mensajeBienvenida;

            if (usuarioEstaLogueado)
            {
                 mensajeBienvenida = "Bienvenido Usuario";
            }
            else
            {
                mensajeBienvenida = "Por favor debes Loguearte";
            }

            Console.WriteLine(mensajeBienvenida);
        }

    }
}
