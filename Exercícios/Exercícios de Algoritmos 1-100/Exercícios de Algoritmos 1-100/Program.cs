using System;

namespace Exercícios_de_Algoritmos_1_100
{
    internal class Program
    {
        private static void Main()
        {
            ex045();
        }

        public static void ex038()
        {
            var i = 6;

            while (i <= 11)
            {
                Console.Write("{0} ", i);
                i++;
            }

            Console.WriteLine("Acabou!");
        }

        public static void ex039()
        {
            var i = 10;

            while (i >= 3)
            {
                Console.Write("{0} ", i);
                i--;
            }

            Console.WriteLine("Acabou!");
        }

        public static void ex040()
        {
            var i = 0;

            while (i <= 18)
            {
                Console.Write("{0} ", i);
                i += 3;
            }

            Console.WriteLine("Acabou!");
        }

        public static void ex041()
        {
            var i = 100;

            while (i >= 0)
            {
                Console.Write("{0} ", i);
                i -= 5;
            }

            Console.WriteLine("Acabou!");
        }

        public static void ex042()
        {
            // Faça um algoritmo que pergunte ao usuário um número inteiro e positivo qualquer e
            // mostre uma contagem até esse valor:

            Console.Write("Digite um valor: ");
            var valor = int.Parse(Console.ReadLine());
            var i = 1;

            Console.Write("Contador: ");
            while (i <= valor)
            {
                Console.Write("{0} ", i);
                i++;
            }

            Console.WriteLine("Acabou!");
        }

        public static void ex043()
        {
            // Desenvolva um algoritmo que mostre uma contagem regressiva de 30 até 1, marcando os
            // números que forem divisíveis por 4

            Console.Write("1-");
            var i = int.Parse(Console.ReadLine());
            Console.Write("Divisiveis por: ");
            var d = int.Parse(Console.ReadLine());
            Console.Write("Mostrar somente os números divisiveis (s/n)? ");
            var option = char.Parse(Console.ReadLine());

            if (option == 's')
            {
                Console.Write("\n");
                while (i >= 1)
                {
                    if (i % d == 0)
                    {
                        Console.Write("{0} ", i);
                    }

                    i--;
                }

                Console.Write("\n");
            }
            else if (option == 'n')
            {
                Console.Write("\n");
                while (i >= 1)
                {
                    Console.Write(i % d == 0 ? "[{0}] \n" : "{0} ", i);
                    i--;
                }

                Console.Write("\n");
            }
        }

        public static void ex044()
        {
            // Crie um algoritmo que leia o valor inicial da contagem, o valor final e o incremento,
            // mostrando em seguida todos os valores no intervalo:

            Console.Write("Digite o primeiro Valor: ");
            var pValor = int.Parse(Console.ReadLine());
            Console.Write("Digite o último Valor: ");
            var uValor = int.Parse(Console.ReadLine());
            Console.Write("Digite o incremento: ");
            var i = int.Parse(Console.ReadLine());
            Console.Write("Contagem: ");

            while (pValor <= uValor)
            {
                Console.Write("{0} ", pValor);
                pValor += i;
            }

            Console.Write("Acabou!\n\n");
        }

        public static void ex045()
        {
            // O programa acima vai ter um problema quando digitarmos o primeiro valor maior que o
            // último. Resolva esse problema com um código que funcione em qualquer situação.

            Console.Write("Digite o primeiro Valor: ");
            var pValor = int.Parse(Console.ReadLine());
            Console.Write("Digite o último Valor: ");
            var uValor = int.Parse(Console.ReadLine());
            Console.Write("Digite o incremento: ");
            var i = int.Parse(Console.ReadLine());
            Console.Write("Contagem: ");

            if (pValor < uValor)
            {
                while (pValor <= uValor)
                {
                    Console.Write("{0} ", pValor);
                    pValor += i;
                }

                Console.Write("Acabou!\n\n");
            }
            else
            {
                while (uValor <= pValor)
                {
                    Console.Write("{0} ", uValor);
                    uValor += i;
                }

                Console.Write("Acabou!\n\n");
            }
        }
    }
}