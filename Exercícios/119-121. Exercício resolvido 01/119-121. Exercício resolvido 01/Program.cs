#pragma warning disable CS8604
#pragma warning disable CS8602
#pragma warning disable CS8601

using _119_121._Exercício_resolvido_01.Entities;
using _119_121._Exercício_resolvido_01.Entities.Enums;
using System.Globalization;

Console.Write("Enter department's name: ");
string deptName = Console.ReadLine();
Console.WriteLine("\nEnter worker data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");;
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department dept = new(deptName);
Worker worker = new(name, level, baseSalary, dept);

Console.Write("How many contracts to this worker? ");
int contracts = int.Parse(Console.ReadLine());

for (int i = 1; i <= contracts; i++)
{
    Console.WriteLine($"\nEnter #{i} contract data:");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());

    HourContract contract = new(date, valuePerHour, hours);
    worker.AddContract(contract);
}

Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear[..2]);
int year = int.Parse(monthAndYear[3..]);

Console.WriteLine($"Name: {worker.Name}\n" +
    $"Department: {worker.Department.Name}\n" +
    $"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");