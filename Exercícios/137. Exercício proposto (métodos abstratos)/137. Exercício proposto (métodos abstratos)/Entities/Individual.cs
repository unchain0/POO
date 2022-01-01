namespace _137._Exercício_proposto__métodos_abstratos_.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.15;
            double taxDeducted = 0.5;

            if (AnualIncome >= 20000.00)
            {
                tax = 0.25;
            }
            if (HealthExpenditures == 0.0)
            {
                taxDeducted = 0.0;
            }

            return (AnualIncome * tax) - (HealthExpenditures * taxDeducted);
        }
    }
}
