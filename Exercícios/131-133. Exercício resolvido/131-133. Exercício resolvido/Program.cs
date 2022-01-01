#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using _131_133._Exercício_resolvido.Entities;
using System.Globalization;

Employee employee = new();
List<Employee> employeeList = new();

Console.Write("Enter the number of employees: ");
int emp = int.Parse(Console.ReadLine());

for (int i = 1; i <= emp; i++)
{
    Console.WriteLine($"Employee #{i} data:");
    Console.Write("Outsourced (y/n)? ");
    char option = char.Parse(Console.ReadLine().ToLower());

    if (option == 'y')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Value per hour: ");
        double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        OutsourcedEmployee oe = new(name, hours, valuePerHour, additionalCharge);
        employeeList.Add(oe);
    }

    else if (option == 'n')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Hours: ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Value per hour: ");
        double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        employee = new(name, hours, valuePerHour);
        employeeList.Add(employee);
    }

    else
    {
        i--;
    }
}

Console.WriteLine("\nPAYMENTS");
foreach (Employee e in employeeList)
{
    Console.WriteLine($"{e.Name} - ${e.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
}