using System;
using System.Globalization;

namespace Membros_estáticos___P1 {

    internal class Program {

        private static void Main(string[] args) {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Valor de PI: {Calculadora.PI.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}