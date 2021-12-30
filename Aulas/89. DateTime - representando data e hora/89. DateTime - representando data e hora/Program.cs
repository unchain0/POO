using System;
using System.Globalization;

namespace _89._DateTime___representando_data_e_hora {
    internal class Program {
        static void Main(string[] args) {

            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("31/10/2021 16:08:50", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            /*
            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2021, 10, 31);
            DateTime d3 = new DateTime(2021, 10, 31, 15, 53, 0);
            DateTime d4 = new DateTime(2021, 10, 31, 15, 53, 3, 500);

            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow;

            Console.WriteLine();
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine();

            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine();
            */

            /*
            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime d3 = DateTime.Parse("31/08/2021");
            DateTime d4 = DateTime.Parse("31/08/2021 16:02:48");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            */
        }
    }
}
