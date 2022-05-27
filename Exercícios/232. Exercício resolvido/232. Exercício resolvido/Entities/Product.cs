using System.Globalization;

namespace _232._Exercício_resolvido.Entities;

internal class Product
{
    public Product(string? name, double price)
    {
        Name = name;
        Price = price;
    }

    public string? Name { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"{Name}," +
               $"{Price.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}