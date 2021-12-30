using System;

namespace _71._Exercício_de_fixação__vetores_ {

    internal class Program {

        private static void Main(string[] args) {
            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int quartos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quartos; i++) {
                Console.WriteLine("\nAluguel #" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 1; i < 10; i++) if (vect[i] != null) Console.WriteLine("{0}: {1}", i, vect[i]);
        }
    }
}
