using System;
using System.Collections.Generic;

namespace Listas___P2
{

    internal class Program
    {

        private static void Main(string[] args)
        {
            List<string> list = new();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Traçin();

            Console.WriteLine($"List count: {list.Count}\n");

            string s1 = list.Find(x => x[0] == 'A'); // Expressão lambda... x => x[0] == 'A'
            Console.WriteLine($"First 'A': {s1}");
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Last 'A': {s2}");

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"\nFirst position 'A': {pos1}");
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Last position 'A': {pos2}");

            List<string> list2 = list.FindAll(x => x.Length == 5); // Names that begin with the letter M
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2); // Marco and Bob removed:
            Traçin();
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M'); // Removed names with the letter M:
            Traçin();
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }

        public static void Traçin() => Console.WriteLine("=======================================");
    }
}
