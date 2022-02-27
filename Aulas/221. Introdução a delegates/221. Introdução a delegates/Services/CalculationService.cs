namespace _221._Introdução_a_delegates.Services
{
    internal class CalculationService
    {
        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine(max);
        }

        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine(sum);
        }

        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Square(double x)
        {
            return Math.Pow(x, 2);
        }

        public static ulong Factorial(ulong x)
        {
            ulong fat;
            for (fat = 1; x > 1; x--)
            {
                fat *= x;
            }
            return fat;
        }
    }
}
