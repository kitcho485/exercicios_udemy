using System;
using System.Globalization;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, trianguloRetangulo, circulo, trapezio, quadrado, retangulo;

            String[] valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);
 
            trianguloRetangulo = a * c / 2.0;
            circulo = 3.14159 * c * c;
            trapezio = (a + b) / 2.0 * c;
            quadrado = b * b;
            retangulo = a * b;

            Console.WriteLine("Triangulo: " + trianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Ciruculo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
