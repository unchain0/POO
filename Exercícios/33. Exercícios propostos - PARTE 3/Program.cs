using System;
using System.Globalization;

namespace _33._Exercícios_propostos___PARTE_3 {

    internal class Program {

        private static void Main(string[] args) {
            //ex001();
            //ex002();
            ex003();
        }

        private static void ex001() {
            int senha = 0;
            while (senha != 2002) {
                senha = int.Parse(Console.ReadLine());
                if (senha != 2002) Console.WriteLine("Senha Invalida");
            }
            Console.WriteLine("Acesso Permitido");
        }

        private static void ex002() {
            int x = 1, y = 1;
            while (x != 0 || y != 0) {
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (x > 0.0 && y > 0.0) Console.WriteLine("primeiro");
                else if (x > 0.0 && y < 0.0) Console.WriteLine("quarto");
                else if (x < 0.0 && y < 0.0) Console.WriteLine("terceiro");
                else if (x < 0.0 && y > 0.0) Console.WriteLine("segundo");
                else Console.WriteLine();
            }
        }

        private static void ex003() {
            int alcool = 0, gasolina = 0, diesel = 0, fim = 0;
            while (fim != 4) {
                int produto = int.Parse(Console.ReadLine());
                if (produto == 1) alcool++;
                else if (produto == 2) gasolina++;
                else if (produto == 3) diesel++;
                else if (produto == 4) fim += 4;
            }
            Console.WriteLine("MUITO OBRIGADO\nAlcool: {0}\nGasolina: {1}\nDiesel: {2}", alcool, gasolina, diesel);
        }
    }
}
