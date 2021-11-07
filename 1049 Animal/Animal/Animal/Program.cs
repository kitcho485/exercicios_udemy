using System;

namespace Animal {
    class Program {
        static void Main(string[] args) {
            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine();
            string palavra3 = Console.ReadLine();

            if (palavra1 == "vertebrado") {
                if (palavra2 == "ave") {
                    if (palavra3 == "carnivoro") {
                        Console.WriteLine("aguia");
                    } else {
                        Console.WriteLine("pomba");
                    }
                }
            }
        }
    }
}
