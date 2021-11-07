using System;
using System.Globalization;

namespace Media1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double peso1 = 3.5;
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double peso2 = 7.5;

            double mp = (peso1 * nota1 + peso2 * nota2) / (peso1 + peso2);

            Console.WriteLine("MEDIA = " + mp.ToString("F5", CultureInfo.InvariantCulture));
            Console.ReadLine();
           

        }
    }
}
