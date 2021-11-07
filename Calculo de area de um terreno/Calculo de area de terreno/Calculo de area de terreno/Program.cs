using System;
using System.Globalization;

namespace Calculo_de_area_de_terreno
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQadrado, area, preco;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = comprimento * largura;
            preco = area * precoMetroQadrado;

            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preço = " + preco.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
