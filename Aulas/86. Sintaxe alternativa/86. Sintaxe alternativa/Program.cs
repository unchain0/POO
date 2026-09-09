using System;
using System.Globalization;

namespace _86._Sintaxe_alternativa
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // desconto de 10% ou 5%
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            double total = preco - desconto;

            Console.WriteLine("\nR$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
