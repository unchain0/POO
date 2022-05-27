using System.Globalization;
using _232._Exercício_resolvido.Entities;

#pragma warning disable CS8602
#pragma warning disable CS8604

static void Print<T>(IEnumerable<T> collection)
{
    foreach (var obj in collection)
        if (obj != null)
            Console.WriteLine(obj);
    Console.WriteLine();
}

Console.Write("Enter full file path: "); // C:\temp\in.csv
var path = Console.ReadLine();
List<Product> products = new();

try
{
    using var sr = File.OpenText(path);
    while (!sr.EndOfStream)
    {
        var line = sr.ReadLine().Split(',');
        var name = line[0];
        var price = double.Parse(line[1], CultureInfo.InvariantCulture);
        products.Add(new Product(name, price));
    }

    // double avgA = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
    var avg =
    (
        from p in products
        select p.Price).DefaultIfEmpty(0.0).Average();
    Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

    // var listNamesA = products.Where(p => p.Price < avg).Select(p => p.Name).OrderByDescending(p => p);
    IOrderedEnumerable<string?> listNames =
    (
        from p in products
        where p.Price < avg
        select p.Name).OrderByDescending(p => p);
    Print(listNames);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}