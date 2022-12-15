using System;
using System.Globalization;

namespace Começando_a_resolver_um_segundo_problema_exemplo {

    internal class Program {

        private static void Main(string[] args) {
            Produto p = new("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preço);
        }
    }
}
