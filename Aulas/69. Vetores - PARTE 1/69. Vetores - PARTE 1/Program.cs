using System;
using System.Globalization;

namespace _69_Vetores_PARTE_1 {

    internal class Program {

        private static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n]; // Criando vetor
            double sum = 0;
            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += vect[i];
            }
            double avg = sum / n;

            Console.WriteLine("\nAVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
