#pragma warning disable CS8604
#pragma warning disable CS8600

using _146._Exercício_proposto__exceções_.Entities;
using _146._Exercício_proposto__exceções_.Entities.AccountExceptions;
using System.Globalization;

try
{
    Console.Write("Enter account data\nNumber: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw limit: ");
    double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account acc = new(number, holder, balance, withdrawLimit);

    Console.Write("\nEnter amount for withdraw: ");
    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    acc.Withdraw(amount);
    Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
}
catch (AccountException e)
{
    Console.WriteLine("Withdraw error: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Error in format: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}