#pragma warning disable CS8602
#pragma warning disable CS8604

using _232._Exercício_resolvido.Entities;
using System.Globalization;

static void Print<T>(IEnumerable<T> collection) {
    foreach (T obj in collection) {
        Console.WriteLine(obj);
    }
    Console.WriteLine();
}

Console.Write("Enter full file path: "); // C:\temp\in.csv
string path = Console.ReadLine();
List<Product> products = new();

try {
    using StreamReader sr = File.OpenText(path);
    while (!sr.EndOfStream) {
        string[] line = sr.ReadLine().Split(',');
        string name = line[0];
        double price = double.Parse(line[1], CultureInfo.InvariantCulture);
        products.Add(new Product(name, price));
    }
    // double avgA = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
    double avg =
        (from p in products
         select p.Price).DefaultIfEmpty(0.0).Average();
    Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

    // var listNamesA = products.Where(p => p.Price < avg).Select(p => p.Name).OrderByDescending(p => p);
    IOrderedEnumerable<string>? listNames =
        (from p in products
         where p.Price < avg
         select p.Name).OrderByDescending(p => p);
    Print(listNames);
}
catch (Exception e) {
    Console.WriteLine(e.Message);
}