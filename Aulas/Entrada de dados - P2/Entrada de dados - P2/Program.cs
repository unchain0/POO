using System;
using System.Globalization;

namespace Entrada_de_dados_P2
{
    internal class Program
    {
        private static void Line()
        {
            Console.Write("\n");
        }

        private static void Exercicio()
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre con o preço de um produto:");
            double preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string ultnome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Line();

            Console.WriteLine($"{nome}\n{quartos}\n{preço.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"{ultnome}\n{idade}\n{altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        private static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine()); // 35
            char ch = char.Parse(Console.ReadLine()); // F
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // 4.32

            string[] vet = Console.ReadLine().Split(' '); // Maria F 23 1.68
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Line();
            Console.WriteLine($"Você digitou:\n{n1}\n{ch}\n{n2.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"{nome} {sexo} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");
            Exercicio();
        }
    }
}