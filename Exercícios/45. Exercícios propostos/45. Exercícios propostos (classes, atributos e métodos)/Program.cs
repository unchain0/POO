using System;
using System.Globalization;

namespace _45._Exercícios_propostos__classes__atributos_e_métodos_ {

    internal class Program {

        private static void Main(string[] args) {
            //ex001();
            //ex002();
            ex003();
        }

        private static void ex001() {
            Retangulo retangulo = new Retangulo();

            Console.Write("Entre a largura e altura do retângulo: ");
            string[] vet = Console.ReadLine().Split(' ');
            retangulo.Largura = double.Parse(vet[0], CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(vet[1], CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void ex002() {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: {0}, $ {1}", funcionario.Nome, funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: {0}, $ {1}", funcionario.Nome, funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void ex003() {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado()) Console.WriteLine("APROVADO");
            else aluno.Reprovado();
        }
    }
}
