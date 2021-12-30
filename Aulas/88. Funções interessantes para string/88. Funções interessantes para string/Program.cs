using System;

namespace _88._Funções_interessantes_para_string {
    internal class Program {
        private static void Main(string[] args) {
            string original = "abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original[3..];
            string s5 = original[3..5];

            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine($"Original: -{original}-\n");

            Console.WriteLine($"ToUpper: -{s1}-"); // maiúsculo
            Console.WriteLine($"ToLower: -{s2}-"); // minúsculo
            Console.WriteLine($"Trim: -{s3}-\n"); // apagar espaços

            Console.WriteLine($"IndexOf('bc'): {n1}");
            Console.WriteLine($"LastIndexOf('bc'): {n2}\n");

            Console.WriteLine($"Substring[3..]: -{s4}-"); // recortar string
            Console.WriteLine($"Substring[3..5]: -{s5}-\n"); // recortar string

            Console.WriteLine($"Replace('a', 'x'): -{s6}-"); // substituir caracteres
            Console.WriteLine($"Replace('abc', 'xy'): -{s7}-\n"); // substituir strings

            Console.WriteLine($"IsNullOrEmpty(original): {b1}"); // nula ou vazia
            Console.WriteLine($"IsNullOrWhiteSpace(original): {b2}"); // nula ou espaço em branco
        }
    }
}
