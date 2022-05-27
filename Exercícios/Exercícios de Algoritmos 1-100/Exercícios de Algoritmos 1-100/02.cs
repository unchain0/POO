using System;
using System.Globalization;

namespace Exercícios_de_Algoritmos_1_100
{
    internal class Passo02CondiçõesBásicas
    {
        public static void ex017()
        {
            // Escreva um programa que pergunte a velocidade de um carro. Caso ultrapasse 80Km / h,
            // exiba uma mensagem dizendo que o usuário foi multado.Nesse caso, exiba o valor da
            // multa, cobrando R$5 por cada Km acima da velocidade permitida.

            Console.Write("Velocidade: ");
            var velocidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var multa = (velocidade - 80.0) * 5.0;

            if (velocidade > 80.0)
            {
                Console.WriteLine("\nMulta de R$ " + multa.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("\n{0}Km/h velocidade permitida.",
                    velocidade.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

        public static void ex018()
        {
            // Faça um programa que leia o ano de nascimento de uma pessoa, calcule a idade dela e
            // depois mostre se ela pode ou não votar.

            Console.Write("Ano de nascimento: ");
            var ano = int.Parse(Console.ReadLine());
            var idade = 2021 - ano;

            Console.WriteLine(idade >= 18 ? "Pode votar.. {0} anos" : "Não pode votar.. {0} anos", idade);
        }

        public static void ex019()
        {
            // Crie um algoritmo que leia o nome e as duas notas de um aluno, calcule a sua média e
            // mostre na tela. No final, analise a média e mostre se o aluno teve ou não um bom
            // aproveitamento (se ficou acima da média 7.0).

            Console.Write("Nota 1: ");
            var nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            var nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var media = (nota1 + nota2) / 2.0;

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(media >= 7.0 ? "Bom aproveitamento." : "Mal aproveitamento.");
        }

        public static void ex020()
        {
            Console.Write("Digite algum número inteiro: ");
            var num = int.Parse(Console.ReadLine());

            Console.WriteLine(num % 2 == 0 ? "{0} par." : "{0} ímpar.", num);
        }

        public static void ex021()
        {
            // Faça um algoritmo que leia um determinado ano e mostre se ele é ou não BISSEXTO.
            Console.Write("Digite algum ano: ");
            var ano = int.Parse(Console.ReadLine());

            Console.WriteLine(ano % 4 == 0 ? "Ano {0}, bissexto." : "Ano {0}, não bissexto.", ano);
        }

        public static void ex022()
        {
            // Escreva um programa que leia o ano de nascimento de um rapaz e mostre a sua situação
            // em relação ao alistamento militar.

            Console.Write("Ano de nascimento: ");
            var nascimento = int.Parse(Console.ReadLine());
            var idade = 2021 - nascimento;

            if (idade < 18)
            {
                Console.WriteLine("Você tem {0} anos, faltam {1} anos para o alistamento.", idade, 18 - idade);
            }
            else
            {
                Console.WriteLine("Você tem {0} anos, já se passaram {1} anos do alistamento.", idade, idade - 18);
            }
        }

        public static void ex023()
        {
            // Numa promoção exclusiva para o Dia da Mulher, uma loja quer dar descontos para todos,
            // mas especialmente para mulheres. Faça um programa que leia nome, sexo e o valor das
            // compras do cliente e calcule o preço com desconto.

            Console.Write("Nome: ");
            Console.ReadLine();
            Console.Write("Sexo (H ou M): ");
            var sexo = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Valor das compras: R$ ");
            var valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = sexo is 'M' ? 0.13 : 0.05;
            double total = valor - valor * desconto;

            Console.WriteLine("Total a pagar: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ex024()
        {
            // Faça um algoritmo que pergunte a distância que um passageiro deseja percorrer em Km.
            // Calcule o preço da passagem, cobrando R$0.50 por Km para viagens até 200Km e R$0.45
            // para viagens mais longas.

            Console.Write("Distância que deseja percorrer: ");
            var distancia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var taxa = distancia <= 200.0 ? 0.50 : 0.45;

            var total = taxa * distancia;

            Console.WriteLine("Preço da passagem: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ex025()
        {
            // Crie um programa que leia o tamanho de três segmentos de reta. Analise seus
            // comprimentos e diga se é possível formar um triângulo com essas retas.
            // Matematicamente, para três segmentos formarem um triângulo, o comprimento de cada
            // lado deve ser menor que a soma dos outros dois.

            Console.Write("Lado a: ");
            var a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado b: ");
            var b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado c: ");
            var c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a < b + c)
            {
                if (!(b < a + c))
                {
                    return;
                }

                if (c < a + b)
                {
                    Console.WriteLine("\nÉ possível formar um triângulo.");
                }
            }
            else
            {
                Console.WriteLine("\nNão é possível formar um triângulo.");
            }
        }
    }
}