using System;

namespace _80._Exercício_resolvido__matrizes_ {
    internal class Program {
        private static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i <= mat.Rank; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < mat.GetLength(1); j++) {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i <= mat.Rank; i++) {
                Console.Write($"{mat[i, i]} ");
            }

            int nn = 0;
            for (int i = 0; i <= mat.Rank; i++) {
                for (int j = 0; j < mat.GetLength(1); j++) {
                    if (mat[i, j] < 0) {
                        nn++;
                    }
                }
            }
            Console.Write("\nNegative numbers = " + nn);
        }
    }
}
