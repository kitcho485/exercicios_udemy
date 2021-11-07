using System;

namespace Condicao_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;
            
            Console.WriteLine("Que horas são?");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12) {

                Console.WriteLine("Bom dia!");
            }
            else {
                Console.WriteLine("Boa tarde!");
            }
            Console.ReadLine();
        }
    }
}
