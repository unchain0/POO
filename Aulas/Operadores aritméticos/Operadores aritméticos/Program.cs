using System;
using System.Globalization;

namespace Operadores_aritméticos
{
    internal class Program
    {
        private static void Line()
        {
            Console.Write("\n");
        }

        private static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3; // Resto da divisão
            double n4 = 10.0 / 8;

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // Math.Pow(x, y) => Calcular potênciação
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); // Math.Sqrt(x) => Calcular raiz
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Line();
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}