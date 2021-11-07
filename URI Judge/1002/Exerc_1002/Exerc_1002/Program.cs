using System;
using System.Globalization;

namespace Exerc_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double raio = a * a;
            double area = n * raio;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();


        }
    }
}
