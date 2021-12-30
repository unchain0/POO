using System;

namespace Funções_sintaxe {

    internal class Program {

        private static void Line() {
            Console.Write("\n");
        }

        private static void Main(string[] args) {
            if (args is null) {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Digite três números:");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int resultado = Maior(n1, n2, n3);
            Line();

            Console.WriteLine("Maior = " + resultado);
        }

        private static int Maior(int a, int b, int c) {
            int m;
            if (a > b && a > c) {
                m = a;
            }
            else if (b > c) {
                m = b;
            }
            else {
                m = c;
            }
            return m;
        } // Função que calcula o maior número
    }
}