using System;
using System.Globalization;

namespace _48._Exercícios_propostos__membros_estáticos_ {

    internal class Program {

        private static void Main(string[] args) {
            ConversorDeMoeda conversor = new ConversorDeMoeda();

            Console.Write("Qual é a contação do dólar? ");
            conversor.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            conversor.Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + conversor.Conversor().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
