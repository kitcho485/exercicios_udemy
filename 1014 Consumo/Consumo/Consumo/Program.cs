using System;
using System.Globalization;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double qtdaLitro, combustivelGasto;

            distancia = int.Parse(Console.ReadLine());
            qtdaLitro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            combustivelGasto = distancia / qtdaLitro;

            Console.WriteLine(combustivelGasto.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
            Console.ReadLine();
        }
    }
}
