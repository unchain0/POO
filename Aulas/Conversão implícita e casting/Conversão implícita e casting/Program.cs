using System;

namespace Conversão_implícita_e_casting
{
    internal class Program
    {
        private static void Line()
        {
            Console.Write("\n");
        }

        private static void Main(string[] args)
        {
            double a;
            int b;

            a = 5.1;
            b = (int)a;

            Console.WriteLine(b);
            Line();

            int a1 = 5;
            int b1 = 2;

            double resultado = (double)a1 / b1;
            Console.WriteLine(resultado);
        }
    }
}