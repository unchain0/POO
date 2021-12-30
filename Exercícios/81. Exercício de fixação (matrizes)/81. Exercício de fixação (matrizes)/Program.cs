using System;

namespace _81._Exercício_de_fixação__matrizes_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Main
            string[] s = Console.ReadLine().Split(' ');
            int linhas = int.Parse(s[0]);
            int colunas = int.Parse(s[1]);

            int[,] mat = new int[linhas, colunas];
            for (int i = 0; i < linhas; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine($"\nPosition {i},{j}:");
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (j < colunas - 1)
                        {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i < linhas - 1)
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }
                }
            }
            #endregion
        }
    }
}
