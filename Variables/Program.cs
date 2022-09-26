using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
    }
}
