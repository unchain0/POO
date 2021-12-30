using System;

namespace Modificador_de_parâmetros_params {

    internal class Program {

        private static void Main(string[] args) {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);
            Console.WriteLine($"{s1} {s2}\n");

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine($"{a}\n");

            int b = 10;
            Calculator.Triple(b, out int triple);
            Console.WriteLine(triple);
        }
    }
}
