#pragma warning disable CS8600
#pragma warning disable CS8604

using _137._Exercício_proposto__métodos_abstratos_.Entities;
using System.Globalization;

List<TaxPayer> taxPayerList = new();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write($"Tax payer #{i} data:\nIndividual or company (i/c)? ");
    char option = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (option == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Individual individual = new(name, anualIncome, healthExpenses);
        taxPayerList.Add(individual);
    }

    else if (option == 'c')
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());

        Company company = new(name, anualIncome, numberOfEmployees);
        taxPayerList.Add(company);
    }
}

Console.WriteLine("\nTAXES PAID");
double sum = 0.0;
foreach (TaxPayer tr in taxPayerList)
{
    Console.WriteLine($"{tr.Name}: $ {tr.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
    sum += tr.Tax();
}

Console.WriteLine($"\nTOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");