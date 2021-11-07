using System;
using System.Globalization;

namespace SalarioBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, totalvendas, salarioComissao;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalvendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioComissao = totalvendas * 15.0 / 100 + salario;

            Console.WriteLine("TOTAL = R$ " + salarioComissao.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
