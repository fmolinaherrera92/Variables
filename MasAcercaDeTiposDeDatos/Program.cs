
using System;


namespace MasAcercaDeTiposDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            var EstatusVentaDeCamisa = EstatusVenta.Candelado;


            Console.WriteLine(EstatusVentaDeCamisa);
            Casteo Cast = new Casteo();

            Cast.casteooExplicito();

            Cast.casteooImplicito();


        }


    }
}
