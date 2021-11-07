using System;
using System.Globalization;

namespace Media2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double peso1 = 2.0;
            double peso2 = 3.0;
            double peso3 = 5.0;

            double mp = (peso1 * nota1 + peso2 * nota2 + peso3 * nota3) / (peso1 + peso2 + peso3);

            Console.WriteLine("MEDIA = " + mp.ToString("F1", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
