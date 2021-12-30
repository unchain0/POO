using System;

namespace Estrutura_condicional
{
    internal class Program
    {
        private static void Line()
        {
            Console.WriteLine("=====================");
        }

        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            int x = 10;

            Console.WriteLine("Bom dia");
            if (x > 5)
            {
                Console.WriteLine("Boa tarde");
            }
            Console.WriteLine("Boa noite");
            Line();

            Console.Write("Entre com um número inteiro: ");
            int par = int.Parse(Console.ReadLine());
            if (par % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar!");
            }
            Line();

            Console.WriteLine("Qual a hora atual? ");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}