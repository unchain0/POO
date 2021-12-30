using System;
using System.Globalization;

namespace _70_Vetores_PARTE_2 {

    internal class Program {

        private static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                Console.Write("\nProduto #" + (i + 1) + "\nNome: ");
                string name = Console.ReadLine();
                Console.Write("Preço: R$");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product(name, price);
                sum += vect[i].Price;
            }
            double avg = Product.Average(sum, n);

            Console.WriteLine("\nAVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
