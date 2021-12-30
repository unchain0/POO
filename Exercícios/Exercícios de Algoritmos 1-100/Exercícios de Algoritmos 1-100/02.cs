using System;
using System.Globalization;

namespace Exercícios_de_Algoritmos_1_100 {

    internal class PASSO_02_CONDIÇÕES_BÁSICAS {

        public static void ex017() {
            // Escreva um programa que pergunte a velocidade de um carro. Caso ultrapasse 80Km / h,
            // exiba uma mensagem dizendo que o usuário foi multado.Nesse caso, exiba o valor da
            // multa, cobrando R$5 por cada Km acima da velocidade permitida.

            Console.Write("Velocidade: ");
            double velocidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double multa = (velocidade - 80.0) * 5.0;

            if (velocidade > 80.0) Console.WriteLine("\nMulta de R$ " + multa.ToString("F2", CultureInfo.InvariantCulture));
            else Console.WriteLine("\n{0}Km/h velocidade permitida.", velocidade.ToString("F1", CultureInfo.InvariantCulture));
        }

        public static void ex018() {
            // Faça um programa que leia o ano de nascimento de uma pessoa, calcule a idade dela e
            // depois mostre se ela pode ou não votar.

            Console.Write("Ano de nascimento: ");
            int ano = int.Parse(Console.ReadLine());
            int idade = 2021 - ano;

            if (idade >= 18) Console.WriteLine("Pode votar.. {0} anos", idade);
            else Console.WriteLine("Não pode votar.. {0} anos", idade);
        }

        public static void ex019() {
            // Crie um algoritmo que leia o nome e as duas notas de um aluno, calcule a sua média e
            // mostre na tela. No final, analise a média e mostre se o aluno teve ou não um bom
            // aproveitamento (se ficou acima da média 7.0).

            Console.Write("Nota 1: ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (nota1 + nota2) / 2.0;

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            if (media >= 7.0) Console.WriteLine("Bom aproveitamento.");
            else Console.WriteLine("Mal aproveitamento.");
        }

        public static void ex020() {
            Console.Write("Digite algum número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) Console.WriteLine("{0} par.", num);
            else Console.WriteLine("{0} ímpar.", num);
        }

        public static void ex021() {
            // Faça um algoritmo que leia um determinado ano e mostre se ele é ou não BISSEXTO.
            Console.Write("Digite algum ano: ");
            int ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 0) Console.WriteLine("Ano {0}, bissexto.", ano);
            else Console.WriteLine("Ano {0}, não bissexto.", ano);
        }

        public static void ex022() {
            // Escreva um programa que leia o ano de nascimento de um rapaz e mostre a sua situação
            // em relação ao alistamento militar.

            Console.Write("Ano de nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());
            int idade = 2021 - nascimento;

            if (idade < 18) Console.WriteLine("Você tem {0} anos, faltam {1} anos para o alistamento.", idade, 18 - idade);
            else Console.WriteLine("Você tem {0} anos, já se passaram {1} anos do alistamento.", idade, idade - 18);
        }

        public static void ex023() {
            // Numa promoção exclusiva para o Dia da Mulher, uma loja quer dar descontos para todos,
            // mas especialmente para mulheres. Faça um programa que leia nome, sexo e o valor das
            // compras do cliente e calcule o preço com desconto.

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Sexo (H ou M): ");
            char sexo = char.Parse(Console.ReadLine());
            Console.Write("Valor das compras: R$ ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto, total;
            if (sexo == 'M' || sexo == 'm') desconto = 0.13;
            else desconto = 0.05;
            total = valor - (valor * desconto);

            Console.WriteLine("Total a pagar: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ex024() {
            // Faça um algoritmo que pergunte a distância que um passageiro deseja percorrer em Km.
            // Calcule o preço da passagem, cobrando R$0.50 por Km para viagens até 200Km e R$0.45
            // para viagens mais longas.

            Console.Write("Distância que deseja percorrer: ");
            double distancia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double taxa, total;
            if (distancia <= 200.0) taxa = 0.50;
            else taxa = 0.45;
            total = taxa * distancia;

            Console.WriteLine("Preço da passagem: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ex025() {
            // Crie um programa que leia o tamanho de três segmentos de reta. Analise seus
            // comprimentos e diga se é possível formar um triângulo com essas retas.
            // Matematicamente, para três segmentos formarem um triângulo, o comprimento de cada
            // lado deve ser menor que a soma dos outros dois.

            Console.Write("Lado a: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado b: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado c: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a < b + c) {
                if (b < a + c) {
                    if (c < a + b) {
                        Console.WriteLine("\nÉ possível formar um triângulo.");
                    }
                }
            } else Console.WriteLine("\nNão é possível formar um triângulo.");
        }
    }
}
