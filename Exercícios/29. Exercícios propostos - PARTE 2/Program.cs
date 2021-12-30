using System;
using System.Globalization;

namespace _29._Exercícios_propostos___PARTE_2 {

    internal class Program {

        private static void Main(string[] args) {
            //ex001();
            //ex002();
            //ex003();
            //ex004();
            //ex005();
            //ex006();
            //ex007();
            ex008();
        }

        private static void ex001() {
            int num = int.Parse(Console.ReadLine());

            if (num >= 0) {
                Console.WriteLine("NAO NEGATIVO");
            } else {
                Console.WriteLine("NEGATIVO");
            }
        }

        private static void ex002() {
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                Console.WriteLine("PAR");
            } else {
                Console.WriteLine("IMPAR");
            }
        }

        private static void ex003() {
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Sao Multiplos");
            } else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }

        private static void ex004() {
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            int horaInicial = int.Parse(vet[0]);
            int horaFinal = int.Parse(vet[1]);

            int duracao;
            if (horaInicial < horaFinal) duracao = horaFinal - horaInicial;
            else duracao = 24 - horaInicial + horaFinal;

            Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
        }

        private static void ex005() {
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            int codigo = int.Parse(vet[0]);
            int quant = int.Parse(vet[1]);

            double preco = 0;
            switch (codigo) {
                case 1:
                    preco = 4.00;
                    break;

                case 2:
                    preco = 4.50;
                    break;

                case 3:
                    preco = 5.00;
                    break;

                case 4:
                    preco = 2.00;
                    break;

                case 5:
                    preco = 1.50;
                    break;

                default:
                    Console.WriteLine("1-5 pls");
                    break;
            }
            preco *= quant;

            if (preco != 0) Console.WriteLine("Total: R$ {0}", preco.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void ex006() {
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string intervalo = "";

            if (num < 0.0 || num > 100.0) intervalo = "Fora do intervalo";
            else if (num <= 25.0) intervalo = "Intervalo [0,25]";
            else if (num <= 50.0) intervalo = "Intervalo [25,50]";
            else if (num <= 75.0) intervalo = "Intervalo [50,75]";
            else if (num <= 100.0) intervalo = "Intervalo [75,100]";

            Console.WriteLine(intervalo);
        }

        private static void ex007() {
            string[] vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0]);
            double y = double.Parse(vet[1]);
            string eixo;

            if (x > 0.0 && y > 0.0) eixo = "Q1";
            else if (x < 0.0 && y > 0.0) eixo = "Q2";
            else if (x < 0.0 && y < 0.0) eixo = "Q3";
            else if (x > 0.0 && y < 0.0) eixo = "Q4";
            else eixo = "Origem"; // x == 0 && y == 0

            Console.WriteLine(eixo);
        }

        private static void ex008() {
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (renda <= 2000.0) imposto = 0.0;
            else if (renda <= 3000.0) imposto = (renda - 2000.0) * 0.08;
            else if (renda <= 4500.0) imposto = (renda - 3000.0) * 0.18 + 1000.0 * 0.08;
            else imposto = (renda - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;

            if (imposto == 0.0) Console.WriteLine("Isento");
            else Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
