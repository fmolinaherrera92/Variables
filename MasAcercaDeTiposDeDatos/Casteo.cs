using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasAcercaDeTiposDeDatos
{
    class Casteo
    {
        // Casteo Explicito de Entero a Double
        public void casteooExplicito() { 
            var cantidad = 7;
            var cantidad2 = 4;


            var ResulDivision = (double)cantidad / cantidad2;

            Console.WriteLine(ResulDivision);

            // Otro Tipo de Casteo Explicito de Int a Byte
            byte byte1;
            int int1= 3;
            byte1 =(byte)int1;

            Console.WriteLine(byte1);

        }
        // Casteo Implicito de Entero a Double
        public void casteooImplicito()
        {
            byte byte2= 100;
            int int2;

            int2 = byte2;
            Console.WriteLine(int2);
        }
}
}
