using System;

namespace Operadores_lógicos
{
    internal class Program
    {
        private static void Line()
        {
            Console.WriteLine("=======");
        }

        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            bool c1 = 2 > 3 || 4 != 5; // 2 maior do que 3 'ou' 4 diferente de 5
            bool c2 = !(2 > 3) && 4 != 5; // 'não' 2 maior do que 3 'e' 4 diferente de 5

            Console.WriteLine(c1); // true
            Console.WriteLine(c2); // true
            Line();

            bool c3 = 10 < 5; // 10 menor do que 5
            bool c4 = c1 || c2 && c3; // c1 'ou' c2 'e' c3
            bool c5 = (c1 || c2) && c3; // (c1 'ou' c2) 'e' c3

            Console.WriteLine(c3); // false
            Console.WriteLine(c4); // true
            Console.WriteLine(c5); // false
        }
    }
}