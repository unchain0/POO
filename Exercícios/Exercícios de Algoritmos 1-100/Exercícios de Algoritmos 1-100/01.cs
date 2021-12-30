using System;
using System.Globalization;

namespace Exercícios_de_Algoritmos_1_100 {

    internal class PASSO_01_SEQUÊNCIAS_BÁSICAS {

        public static void ex001() {
            // Escreva um programa que mostre na tela a mensagem "Olá, Mundo!"
            Console.WriteLine("Olá, Mundo!");
        }

        public static void ex002() {
            // Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boasvindas
            // para ela:

            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Olá {0}, é um prazer te conhecer!", nome);
        }

        public static void ex003() {
            // Crie um programa que leia o nome e o salário de um funcionário, mostrando no final
            // uma mensagem.

            Console.Write("Nome do Funcionário: ");
            string nome = Console.ReadLine();
            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("O funcionário {0} tem um salário de R${1} em Junho.", nome, salario);
        }

        public static void ex004() {
            // Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório entre eles.

            Console.Write("Digite um valor: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("A soma entre {0} e {1} é igual a {2}.", n1, n2, n1 + n2);
        }

        public static void ex005() {
            // Faça um programa que leia as duas notas de um aluno em uma matéria e mostre na tela a
            // sua média na disciplina.

            Console.Write("Nota 1: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (n1 + n2) / 2;

            Console.WriteLine("A média entre {0} e {1} é igual a {2}",
                n1.ToString("F1", CultureInfo.InvariantCulture),
                n2.ToString("F1", CultureInfo.InvariantCulture),
                media.ToString("F1", CultureInfo.InvariantCulture));
        }

        public static void ex006() {
            // Faça um programa que leia um número inteiro e mostre o seu antecessor e seu sucessor.

            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            int sucessor = num + 1, antecessor = num - 1;

            Console.WriteLine("O antecessor de {0} é {1}", num, antecessor);
            Console.WriteLine("O sucessor de {0} é {1}", num, sucessor);
        }

        public static void ex007() {
            // Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a sua terça parte.

            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double dobro = num * 2, tercaParte = num / 3;

            Console.WriteLine("O dobro de {0} é {1}",
                num.ToString("F1", CultureInfo.InvariantCulture),
                dobro.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("A terça parte de {0} é {1}",
                num.ToString("F1", CultureInfo.InvariantCulture),
                tercaParte.ToString("F5", CultureInfo.InvariantCulture));
        }

        public static void ex008() {
            // Desenvolva um programa que leia uma distância em metros e mostre os valores relativos
            // em outras medidas.

            Console.Write("Digite uma distância em metros: ");
            double metros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double km = metros / 1000.0, hm = metros / 100.0, dam = metros / 10.0;
            double dm = metros * 10.0, cm = metros * 100.0, mm = metros * 1000.0;

            Console.WriteLine("A distância de {0}m corresponde a:",
                metros.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("\n{0}Km\n{1}Hm\n{2}Dam\n\n{3}dm\n{4}cm\n{5}mm",
                km.ToString(CultureInfo.InvariantCulture),
                hm.ToString(CultureInfo.InvariantCulture),
                dam.ToString(CultureInfo.InvariantCulture),
                dm.ToString("F1", CultureInfo.InvariantCulture),
                cm.ToString("F1", CultureInfo.InvariantCulture),
                mm.ToString("F1", CultureInfo.InvariantCulture));
        }

        public static void ex009() {
            // Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$) e
            // mostre quantos dólares ela pode comprar.

            Console.Write("R$ ");
            double carteira = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double dolar = carteira / 5.24;

            Console.WriteLine("$ " + dolar.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ex010() {
            // Faça um algoritmo que leia a largura e altura de uma parede, calcule e mostre a área
            // a ser pintada e a quantidade de tinta necessária para o serviço, sabendo que cada
            // litro de tinta pinta uma área de 2metros quadrados.

            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Largura: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * altura;
            double tinta = area / 2;

            Console.WriteLine("Quantidade de tinta necessária para o serviço: {0}L",
                tinta.ToString("F1", CultureInfo.InvariantCulture));
        }

        public static void ex011() {
            // Desenvolva uma lógica que leia os valores de A, B e C de uma equação do segundo grau
            // e mostre o valor de Delta.

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double delta = Math.Pow(b, 2) - 4 * a * c;
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("\nΔ = " + delta.ToString("F0", CultureInfo.InvariantCulture));
            Console.WriteLine("x¹ = {0}\nx² = {1}",
                x1.ToString("F0", CultureInfo.InvariantCulture),
                x2.ToString("F0", CultureInfo.InvariantCulture));
        }

        public static void ex012() {
            // Crie um programa que leia o preço de um produto, calcule e mostre o seu PREÇO
            // PROMOCIONAL, com 5 % de desconto.

            Console.Write("Produto: ");
            string produto = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto;

            if (preco > 5.0) desconto = preco - (preco * 0.05);
            else desconto = preco;

            Console.WriteLine("{0}, R$ {1}", produto, desconto.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ex013() {
            // Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o seu novo
            // salário, com 15 % de aumento.

            Console.Write("R$ ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double aumento = salario + (salario * 0.15);

            Console.WriteLine("\nAumento de 15%\nR$ " + aumento.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ex014() {
            // A locadora de carros precisa da sua ajuda para cobrar seus serviços. Escreva um
            // programa que pergunte a quantidade de Km percorridos por um carro alugado e a
            // quantidade de dias pelos quais ele foi alugado. Calcule o preço total a pagar,
            // sabendo que o carro custa R$90 por dia e R$0,20 por Km rodado.

            Console.Write("Quantidade de Km percorridos: ");
            double km = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade de dias: ");
            int dias = int.Parse(Console.ReadLine());
            double total = km * 0.20 + dias * 90;

            Console.WriteLine("Total a pagar R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ex015() {
            // Crie um programa que leia o número de dias trabalhados em um mês e mostre o salário
            // de um funcionário, sabendo que ele trabalha 8 horas por dia e ganha R$25 por hora trabalhada.

            Console.Write("Dias trabalhados: ");
            double dias = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = dias * 25.0 * 8.0;

            Console.WriteLine("Salário R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void ex016() {
            // Escreva um programa para calcular a redução do tempo de vida de um fumante. Pergunte
            // a quantidade de cigarros fumados por dia e quantos anos ele já fumou. Considere que
            // um fumante perde 10 min de vida a cada cigarro. Calcule quantos dias de vida um
            // fumante perderá e exiba o total em dias.

            Console.Write("Quantidade de cigarros fumados por dia: ");
            int cigarros = int.Parse(Console.ReadLine());
            Console.Write("Quantos anos ele já fumou: ");
            int anos = int.Parse(Console.ReadLine());
            double tempo = cigarros * 10.0 * anos;

            double dias = tempo / 1440.0;
            double hora = tempo / 60.0;

            Console.WriteLine("\nVocê já perdeu: {0} dias.\nAproximadamente {1} horas.",
                dias.ToString("F2", CultureInfo.InvariantCulture),
                hora.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
