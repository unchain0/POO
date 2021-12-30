using System;

namespace Operadores_comparativos
{
    internal class Program
    {
        private static void Line()
        {
            Console.WriteLine("===============");
        }

        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            int a = 10;
            bool c1 = a < 10; // a menor que 10
            bool c2 = a < 20; // a menor que 20
            bool c3 = a > 10; // a maior que 10
            bool c4 = a > 5; // a maior que 5

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Line();

            bool c5 = a <= 10; // a menor ou igual a 10
            bool c6 = a >= 10; // a maior ou igual a 10
            bool c7 = a == 10; // a igual a 10
            bool c8 = a != 10; // a diferente de 10

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
        }
    }
}