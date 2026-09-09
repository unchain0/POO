using System;
using System.Globalization;

namespace Vetores___P2
{

    internal class Program
    {

        private static void Main(string[] args)
        {
            Console.Write("Quantos produtos? ");
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nNome: ");
                string name = Console.ReadLine();
                Console.Write("Preço: $ ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            Console.WriteLine("\nAVERAGE PRICE $ " + (sum / n).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
