using System;

namespace Entrada_de_dados_P1
{
    internal class Program
    {
        private static void Line()
        {
            Console.Write("\n");
        }

        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(' '); // Split - função que serve para recortar uma string em pedaços, conforme o caractér que você indicar.
            string a = vet[0], b = vet[1], c = vet[2];

            Line();
            Console.WriteLine($"Você digitou:\n{frase}\n{x}\n{y}\n{z}\n{a}\n{b}\n{c}");
        }
    }
}