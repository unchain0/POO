namespace _137._Exercício_proposto__métodos_abstratos_.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = 0.16;

            if (NumberOfEmployees > 10)
            {
                tax = 0.14;
            }

            return AnualIncome * tax;
        }
    }
}
