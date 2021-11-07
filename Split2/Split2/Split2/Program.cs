
using System;
using System.Globalization;


namespace Split2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int.Parse é usado por que a variavel não é do tipo string.
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // String[] string usado como vetor para receber os dados do usuario e fazer o controle baseado na quantidade de espaço entre palavra.
            // cada palavra será armazenada em uma variavel e sera lida individualmente.
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            // imprimi a variavel n2, converte para string, limita em duas casas decimais e usa a regra do ponto e virgula.
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
