using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string mensaje = "Este string contiene \\ y también \" pues lo escapamos \"";
            Console.WriteLine( mensaje);
        }

        public void CodigoDelCurso()
        {
            int distanciaDeLaTierraAlSolEnKilometros = 150_000_000; // -2,147,483,648 hasta 2,147,483,647
            uint uint2 = 3_000_000_000; // 0 hasta 4,294,967,295

            long long1 = 8_000_000_000_000; // -9,223,372,036,854,775,808 hasta 9,223,372,036,854,775,807
            ulong ulong1 = 16_000_000_000_000; // 0 hasta 18,446,744,073,709,551,615

            byte byte1 = 145; // 0 hasta 255
            sbyte sbyte1 = 100; // -128 hasta 127

            short short1 = 30_000; // -32,768 hasta 32,767
            ushort ushort1 = 65_000; // 0 hasta 65,535
        }

        public void NumerosPuntoFlotantes()
        {
            float altura = 180.123456789f; // Ocupa 4 bytes; Precisión de 6 a 9 dígitos
            double anchura = 45.123456789; // Ocupa 8 bytes; Precisión de 15 a 17 dígitos
            decimal monto = 9.99m; // Ocupa 16 bytes; Precisión de 28 a 29 dígitos (es recomendado temas financieros)

            Console.WriteLine("La altura es:");
            Console.WriteLine(altura);

            Console.WriteLine("La anchura es:");
            Console.WriteLine(anchura);

            Console.WriteLine("El precio es:");
            Console.WriteLine(monto);

        }

        public void Booleanos()
        {
            bool soyFelipe = true;
            bool dosMasDosEsCinco = false;
        }
    }
}
