using System;
using System.Globalization;

namespace Exercícios_de_Algoritmos_1_100 {

    internal class PASSO_03_CONDIÇÕES_COMPOSTAS {

        public static void ex026() {
            // Escreva um algoritmo que leia dois números inteiros e compare-os

            Console.Write("Primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2) Console.WriteLine("O primeiro valor é o maior");
            else if (n1 < n2) Console.WriteLine("O segundo valor é o maior");
            else Console.WriteLine("Não existe valor maior, os dois são iguais");
        }

        public static void ex027() {
            // Crie um programa que leia duas notas de um aluno e calcule a sua média

            Console.Write("NOTA 1: ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("NOTA 2: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (nota1 + nota2) / 2;

            if (media >= 0.0 && media < 5.0) Console.WriteLine("MÉDIA {0}.. REPROVADO", media.ToString("F1", CultureInfo.InvariantCulture));
            else if (media < 7.0) Console.WriteLine("MÉDIA {0}.. RECUPERAÇÃO", media.ToString("F1", CultureInfo.InvariantCulture));
            else Console.WriteLine("MÉDIA {0}.. APROVADO", media.ToString("F1", CultureInfo.InvariantCulture));
        }

        public static void ex028() {
            // Faça um programa que leia a largura e o comprimento de um terreno retangular,
            // calculando e mostrando a sua área em m². O programa também devemostrar a
            // classificação desse terreno

            Console.Write("LARGURA: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("COMPRIMENTO: ");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = comprimento * largura;

            if (area < 100.0) Console.WriteLine("TERRENO POPULAR");
            else if (area < 500.0) Console.WriteLine("TERRENO MASTER");
            else Console.WriteLine("TERRENO VIP");
        }

        public static void ex029() {
            // Desenvolva um programa que leia o nome de um funcionário, seu salário, quantos anos
            // ele trabalha na empresa e mostre seu novo salário

            Console.Write("NOME: ");
            Console.ReadLine();
            Console.Write("SALÁRIO: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("ANOS NA EMPRESA: ");
            int anosNaEmpresa = int.Parse(Console.ReadLine());
            double aumento;

            if (anosNaEmpresa <= 3.0) aumento = 0.03;
            else if (anosNaEmpresa <= 10.0) aumento = 0.125;
            else aumento = 0.2;

            salario += salario * aumento;
            Console.WriteLine("SALÁRIO AUMENTADO: $ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ex030() {
            // Refaça o algoritmo 25, acrescentando o recurso de mostrar que tipo de triângulo será formado:

            Console.Write("Lado a: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado b: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado c: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            if (a == b && a == c && b == c) Console.WriteLine("EQUILÁTERO: todos os lados iguais");
            else if (a == b || a == c || b == c) Console.WriteLine("ISÓSCELES: dois lados iguais");
            else if (a != b && a != c && b != c) Console.WriteLine("ESCALENO: todos os lados diferentes");
        }

        public static void ex031() {
        }

        public static void ex032() {
        }

        public static void ex033() {
            // O Índice de Massa Corpórea (IMC) é um valor calculado baseado na altura e no peso de
            // uma pessoa. De acordo com o valor do IMC, podemos classificar o indivíduo dentro de
            // certas faixas.

            Console.Write("Valor da casa: R$ ");
            double valorCasa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Salário do comprador: R$ ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos anos pretende pagar: ");
            int anos = int.Parse(Console.ReadLine());

            double emprestimo = salario * 0.3;
            double prestacao = valorCasa / (anos * 12);

            if (emprestimo < prestacao) {
                Console.WriteLine("\nEmpréstimo negado!");
            } else {
                Console.WriteLine("\nEmpréstimo aceito!");
                Console.WriteLine("Mensalidade R$ {0}", prestacao.ToString("F2", CultureInfo.InvariantCulture));
            }
        }

        public static void ex034() {
            // O Índice de Massa Corpórea (IMC) é um valor calculado baseado na altura e no peso de
            // uma pessoa. De acordo com o valor do IMC, podemos classificar o indivíduo dentro de
            // certas faixas.

            Console.Write("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite sua altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imc = peso / (altura * altura);

            /*
            if (imc < 18.5) {
                Console.WriteLine("IMC: {0} - Abaixo do peso", imc.ToString("F1", CultureInfo.InvariantCulture));
            } else if (imc < 25) {
                Console.WriteLine("IMC: {0} - Peso ideal", imc.ToString("F1", CultureInfo.InvariantCulture));
            } else if (imc < 30) {
                Console.WriteLine("IMC: {0} - Sobrepeso", imc.ToString("F1", CultureInfo.InvariantCulture));
            } else if (imc < 40) {
                Console.WriteLine("IMC: {0} - Obesidade", imc.ToString("F1", CultureInfo.InvariantCulture));
            } else {
                Console.WriteLine("IMC: {0} - Obesidade mórbida", imc.ToString("F1", CultureInfo.InvariantCulture));
            }
            */

            switch (imc) {
                case < 18.5:
                    Console.WriteLine("IMC: {0} - Abaixo do peso", imc.ToString("F1", CultureInfo.InvariantCulture));
                    break;

                case < 25:
                    Console.WriteLine("IMC: {0} - Peso ideal", imc.ToString("F1", CultureInfo.InvariantCulture));
                    break;

                case < 30:
                    Console.WriteLine("IMC: {0} - Sobrepeso", imc.ToString("F1", CultureInfo.InvariantCulture));
                    break;

                case < 40:
                    Console.WriteLine("IMC: {0} - Obesidade", imc.ToString("F1", CultureInfo.InvariantCulture));
                    break;

                case > 40:
                    Console.WriteLine("IMC: {0} - Obesidade mórbida", imc.ToString("F1", CultureInfo.InvariantCulture));
                    break;
            }
        }

        public static void ex035() {
            // Uma empresa de aluguel de carros precisa cobrar pelos seus serviços. O aluguel de um
            // carro custa R$90 por dia para carro popular e R$150 por dia para carro de luxo. Além
            // disso, o cliente paga por Km percorrido. Faça um programa que leia o tipo de carro
            // alugado (popular ou luxo), quantos dias de aluguel e quantos Km foram percorridos.

            Console.Write("Tipo de carro alugado (popular ou luxo): ");
            string tipoDoCarro = Console.ReadLine().ToLower();
            Console.Write("Dias alugados: ");
            int dias = int.Parse(Console.ReadLine());
            Console.Write("Km percorridos: ");
            double km = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor = 0;

            if (tipoDoCarro == "popular") {
                valor = dias * 90;
                if (km < 100.0) valor += km * 0.20;
                else valor += km * 0.10;
            } else if (tipoDoCarro == "luxo") {
                valor = dias * 150;
                if (km < 200.0) valor += km * 0.30;
                else valor += km * 0.25;
            }

            Console.WriteLine("\nValor a ser pago: R${0}", valor.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ex036() {
            // Um programa de vida saudável quer dar pontos atividades físicas que podem ser
            // trocados por dinheiro. Faça um programa que leia quantas horas de atividade uma
            // pessoa teve por mês, calcule e mostre quantos pontos ela teve e quanto dinheiro ela
            // conseguiu ganhar.

            Console.Write("Horas de atividade: ");
            int horas = int.Parse(Console.ReadLine());

            int pontos = 0;

            if (horas < 10) pontos += horas * 2;
            else if (horas <= 20) pontos += horas * 5;
            else pontos += horas * 10;
            double total = pontos * 0.05;

            Console.WriteLine("\nVocê obteve {0} pontos.\n" +
                "Total de: R${1}",
                pontos,
                total.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ex037() {
            // Uma empresa precisa reajustar o salário dos seus funcionários, dando um aumento de
            // acordo com alguns fatores. Faça um programa que leia o salário atual, o gênero do
            // funcionário e há quantos anos esse funcionário trabalha na empresa.

            Console.Write("Salário: R$");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Gênero (h/m): ");
            char genero = char.Parse(Console.ReadLine());
            Console.Write("Anos de trabalho: ");
            int anos = int.Parse(Console.ReadLine());

            double bonus = 0;

            if (genero == 'm') {
                if (anos < 15) bonus = 0.05;
                else if (anos < 20) bonus = 0.12;
                else bonus = 0.23;
            } else if (genero == 'h') {
                if (anos < 20) bonus = 0.03;
                else if (anos < 30) bonus = 0.13;
                else bonus = 0.25;
            }

            salario += salario * bonus;

            Console.WriteLine("\nNovo salário: R$" + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
