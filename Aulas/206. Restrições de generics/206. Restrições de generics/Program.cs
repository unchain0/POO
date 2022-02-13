#pragma warning disable CS8602
#pragma warning disable CS8604

using _206._Restrições_de_generics.Entities;
using _206._Restrições_de_generics.Services;
using System.Globalization;

CalculationService calculationService = new();
List<Product> list = new();

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] vs = Console.ReadLine().Split(',');
    string name = vs[0];
    double price = double.Parse(vs[1], CultureInfo.InvariantCulture);
    list.Add(new Product(name, price));
}

Product max = calculationService.Max(list);
Console.WriteLine("\nMost expensive:\n" + max);