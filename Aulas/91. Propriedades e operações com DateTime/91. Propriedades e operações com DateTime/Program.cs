using System;

namespace _91._Propriedades_e_operações_com_DateTime
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Propriedades
            DateTime d = new(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);

            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine();
            #endregion

            #region Formatação (DateTime -> string)
            DateTime d1 = new(2001, 8, 15, 13, 45, 58);

            string s1 = d1.ToLongDateString();
            string s2 = d1.ToLongTimeString();
            string s3 = d1.ToShortDateString();
            string s4 = d1.ToShortTimeString();

            string s5 = d1.ToString();
            string s6 = d1.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d1.ToString("yyyy_MM_dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine();
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine();
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine();
            #endregion

            #region Operações com DateTime

            #region Boleto
            DateTime d2 = DateTime.Now;
            DateTime d3 = d2.AddDays(7);

            Console.WriteLine($"Boleto: {d2}");
            Console.WriteLine($"Vencimento: {d3}");
            Console.WriteLine();
            #endregion

            #region Diferença
            DateTime d4 = new(2000, 10, 15);
            DateTime d5 = new(2000, 10, 18);
            TimeSpan t = d5.Subtract(d4);

            Console.WriteLine(t);
            #endregion

            #endregion
        }
    }
}
