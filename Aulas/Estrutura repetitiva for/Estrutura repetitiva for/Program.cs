using System;

namespace Estrutura_repetitiva_for
{

    internal class Program
    {

        private static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0, valor;

            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Valor #{i}: ");
                valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}