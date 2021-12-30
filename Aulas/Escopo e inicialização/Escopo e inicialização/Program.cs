using System;
using System.Globalization;

namespace Escopo_e_inicialização
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = 0.0;
            if (preço > 100.0)
            {
                desconto = preço * 0.1;
                Console.WriteLine($"TOTAL A PAGAR: R$ {preço - desconto:F2}");
            }

            Console.WriteLine($"DESCONTO DE: R$ {desconto:F2}");
        }
    }
}