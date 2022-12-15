using System;
using System.Globalization;

namespace _40._Primeiros_exercícios__classes__objetos_e_atributos_ {

    internal class Program {

        private static void Main(string[] args) {
            //ex000();
            //ex001();
            ex002();
        }

        private static void ex000() {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.Write("Entre com as medidas do triângulo X: ");
            string[] xx = Console.ReadLine().Split(' ');
            x.A = double.Parse(xx[0], CultureInfo.InvariantCulture);
            x.B = double.Parse(xx[1], CultureInfo.InvariantCulture);
            x.C = double.Parse(xx[2], CultureInfo.InvariantCulture);

            Console.Write("Entre com as medidas do triângulo Y: ");
            string[] yy = Console.ReadLine().Split(' ');
            y.A = double.Parse(yy[0], CultureInfo.InvariantCulture);
            y.B = double.Parse(yy[1], CultureInfo.InvariantCulture);
            y.C = double.Parse(yy[2], CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();
            string areaMaior;

            if (areaX > areaY) areaMaior = "X";
            else if (areaX < areaY) areaMaior = "Y";
            else areaMaior = "-_-";

            Console.WriteLine("Área X: {0}\nÁrea Y: {1}\nMaior área: {2}", areaX.ToString("F4"), areaY.ToString("F4"), areaMaior);
        }

        private static void ex001() {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.Write("Dados da primeira pessoa:\nNome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.Write("Dados da segunda pessoa:\nNome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade) Console.WriteLine("Pessoa mais velha: {0}", p1.Nome);
            else Console.WriteLine("Pessoa mais velha: {0}", p2.Nome);
        }

        private static void ex002() {
            Funcionario f1 = new();
            Funcionario f2 = new();

            Console.Write("Dados do primeiro funcionário:\nNome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Dados do segundo funcionário:\nNome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Salário médio = {0}", media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
