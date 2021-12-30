using System;
using System.Globalization;

namespace _35._Exercícios_propostos___PARTE_4 {

    internal class Program {

        private static void Main(string[] args) {
            //ex001();
            //ex002();
            //ex003();
            //ex004();
            //ex005();
            //ex006();
            ex007();
        }

        private static void ex001() {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++) if (i % 2 != 0) Console.WriteLine(i);
        }

        private static void ex002() {
            int n = int.Parse(Console.ReadLine());
            int dentro = 0, fora = 0;
            for (int i = 1; i <= n; i++) {
                int check = int.Parse(Console.ReadLine());
                if (check >= 10 && check <= 20) dentro++;
                else fora++;
            }
            Console.WriteLine("\n{0} in\n{1} out", dentro, fora);
        }

        private static void ex003() {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vet[2], CultureInfo.InvariantCulture);
                double media = (a * 2 + b * 3 + c * 5) / (2 + 3 + 5);

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

        private static void ex004() {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                double x = double.Parse(vet[0]);
                double y = double.Parse(vet[1]);

                if (y == 0) Console.WriteLine("divisao impossivel");
                else {
                    double div = x / y;
                    Console.WriteLine(div.ToString("F1"));
                }
            }
        }

        private static void ex005() {
            int num = int.Parse(Console.ReadLine());
            int fat = 1;
            for (int i = 1; i <= num; i++) fat *= i;
            Console.WriteLine(fat);
        }

        private static void ex006() {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) if (n % i == 0) Console.WriteLine(i);
        }

        private static void ex007() {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                double quadrado = Math.Pow(i, 2);
                double cubo = Math.Pow(i, 3);
                Console.WriteLine("{0} {1} {2}", i, quadrado, cubo);
            }
        }
    }
}
