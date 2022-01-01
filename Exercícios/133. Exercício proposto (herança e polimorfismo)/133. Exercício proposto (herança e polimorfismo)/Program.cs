#pragma warning disable CS8602
#pragma warning disable CS8600
#pragma warning disable CS8604

using _133._Exercício_proposto__herança_e_polimorfismo_.Entities;
using System.Globalization;

List<Product> products = new();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write($"\nProduct #{i} data\nCommon, used or imported (c/u/i)? ");
    char option = char.Parse(Console.ReadLine().ToLower());
    string name = "";
    double price = 0.0;

    if (option == 'i' || option == 'c' || option == 'u')
    {
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.Write("Price: ");
        price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    }

    else
    {
        i--;
    }

    if (option == 'i')
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        ImportedProduct importedProduct = new(name, price, customsFee);
        products.Add(importedProduct);
    }

    else if (option == 'c')
    {
        Product product = new(name, price);
        products.Add(product);
    }

    else if (option == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        UsedProduct usedProduct = new(name, price, date);
        products.Add(usedProduct);
    }
}

Console.WriteLine("\nPRICE TAGS:");
foreach (Product p in products)
{
    Console.WriteLine(p.PriceTag());
}