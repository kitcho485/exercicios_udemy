using System;
using System.Globalization;

namespace CalculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int codPeca1, codPeca2, qtdaPeca1, qtdaPeca2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');

            codPeca1 = int.Parse(valores[0]);
            qtdaPeca1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            codPeca2 = int.Parse(valores[0]);
            qtdaPeca2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qtdaPeca1 + preco2 * qtdaPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
