using System.Globalization;

namespace _199._Exercício_de_fixação.Entities
{
    internal class Installment
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{Date} - {Amount.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
