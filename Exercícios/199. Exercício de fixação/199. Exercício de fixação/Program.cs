#pragma warning disable CS8604

using _199._Exercício_de_fixação.Entities;
using _199._Exercício_de_fixação.Services;
using System.Globalization;

Console.Write("Enter contract data:\nNumber: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int months = int.Parse(Console.ReadLine());

Contract contract = new(number, date, value);
ContractService contractService = new(new PaypalService());
contractService.ProcessContract(contract, months);

Console.WriteLine("\nInstallments:");
foreach (Installment installment in contract.Installments)
{
    Console.WriteLine(installment);
}