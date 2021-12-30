using System;
using System.Globalization;

namespace Exercicio_de_fixaçao
{
    internal class Program
    {
        private static void Line()
        {
            Console.Write("\n");
        }

        private static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preço1 = 2100.0;
            double preço2 = 650.50;
            double medida = 52.234567;

            Console.WriteLine($"Produtos:\n{produto1}, cujo preço é $ {preço1.ToString("F2")}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preço2.ToString("F2")}");
            Line();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Line();
            Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida.ToString("F3")}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}