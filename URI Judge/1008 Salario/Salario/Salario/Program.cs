using System;
using System.Globalization;


namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFuncionario = int.Parse(Console.ReadLine());
            int hTrabalhadas = int.Parse(Console.ReadLine());
            double vHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario;
            
            salario = hTrabalhadas * vHora;

            Console.WriteLine("NUMBER = " + nFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
