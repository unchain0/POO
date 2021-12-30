using System;
using System.Globalization;

namespace _60._Exercício_de_fixação {

    internal class Program {

        private static void Main(string[] args) {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine().ToLower());

            if (resp == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            } else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\nDados da conta:" + conta);
            Console.Write("\nEntre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine("Dados da conta atualizados:" + conta);
            Console.Write("\nEntre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine("Dados da conta atualizados:" + conta);
        }
    }
}
