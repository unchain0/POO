using System;

namespace Nullable
{

    internal class Program
    {

        private static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            double a = x ?? 5.0; // Operador de coalescência nula
            Console.WriteLine(a);

            double b = y ?? 5.0;
            Console.WriteLine(b);
        }
    }
}
