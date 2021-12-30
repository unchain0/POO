using System;
using System.Globalization;

namespace Vetores___P1 {

    internal class Program {

        private static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n]; // CRIA O VETOR NA MEMÓRIA
            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine("\nAVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
