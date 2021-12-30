using System;
using System.Globalization;

namespace _24._Exercícios_propostos___PARTE_1 {

    internal class Program {

        private static void Main(string[] args) {
            //ex001();
            //ex002();
            //ex003();
            //ex004();
            //ex005();
            ex006();
        }

        private static void ex001() {
            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("SOMA = " + (n1 + n2));
        }

        private static void ex002() {
            Console.Write("RAIO: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4"));
        }

        private static void ex003() {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int dif = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + dif);
        }

        private static void ex004() {
            int number = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salary = hour * money;

            Console.WriteLine("\nNUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void ex005() {
            int.Parse(Console.ReadLine());
            int np1 = int.Parse(Console.ReadLine());
            double up1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            int.Parse(Console.ReadLine());
            int np2 = int.Parse(Console.ReadLine());
            double up2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double preco = (up1 * np1) + (up2 * np2);

            Console.WriteLine("\nVALOR A PAGAR: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void ex006() {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double triangulo = A * C / 2;
            double circulo = 3.14159 * Math.Pow(C, 2);
            double trapezio = ((A + B) * C) / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            Console.WriteLine("\nTRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
        }
    }
}
