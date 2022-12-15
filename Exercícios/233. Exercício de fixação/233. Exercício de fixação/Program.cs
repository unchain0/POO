#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using _233._Exercício_de_fixação.Entities;
using System.Globalization;
// ReSharper disable All

static void Print<T>(string message, IEnumerable<T> collection) {
    Console.WriteLine(message);
    foreach (T obj in collection) {
        Console.WriteLine(obj);
    }
}

Console.Write("Enter full file path: "); // C:\temp\in.csv
string path = Console.ReadLine();
Console.Write("Enter salary: ");
double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

List<Employee> employees = new();

try {
    using StreamReader sr = File.OpenText(path);
    while (!sr.EndOfStream) {
        string[] line = sr.ReadLine().Split(',');
        string name = line[0];
        string email = line[1];
        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);
        employees.Add(new Employee(name, email, salary));
    }

    IOrderedEnumerable<string>? r1 =
        (from e in employees
         where e.Salary > limit
         select e.Email).OrderBy(e => e);

    double r2 =
        (from e in employees
         where e.Name[0] == 'M'
         select e.Salary).DefaultIfEmpty(0.0).Sum();

    Print("Email of people whose salary is more than " +
        $"{limit.ToString("F2", CultureInfo.InvariantCulture)}:", r1);

    Console.WriteLine("Sum of salary of people whose name starts with 'M': " +
        r2.ToString("F2", CultureInfo.InvariantCulture));
}
catch (Exception e) {
    Console.WriteLine(e.Message);
}