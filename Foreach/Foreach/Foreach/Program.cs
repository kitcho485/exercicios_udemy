using System;

namespace Foreach {
    class Program {
        static void Main(string[] args) {

            int N = 0;
            N = int.Parse(Console.ReadLine());
            String[] vet = new string[N];

            for (int i = 0; i<N; i++) {
                vet[i] = Console.ReadLine();
            }
            Console.WriteLine("Nome lidos");
            // Para se usar o foreach é necessario dar um apelido para o foreach no casa nomesLidos
            foreach (string nomesLidos in vet) {
                Console.WriteLine(nomesLidos);
            }
        }
    }
}
