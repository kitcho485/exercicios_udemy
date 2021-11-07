using System;


namespace ProdutoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int PROD = a * b;

            Console.WriteLine("PROD = " + PROD);
            Console.ReadLine();
        }
    }
}
