#pragma warning disable CS8604

using _194._Interfaces.Entities;
using _194._Interfaces.Services;
using System.Globalization;

Console.Write("Enter rental data\nCar model: ");
string? model = Console.ReadLine();
Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Return (dd/MM/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Enter price per hour: ");
double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter price per day: ");
double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

CarRental carRental = new(start, finish, new Vehicle(model));
RentalService rentalService = new(hour, day, new BrazilTaxService());
rentalService.ProcessInvoice(carRental);

<<<<<<< HEAD
Console.WriteLine("\nINVOICE:" + carRental.Invoice);
=======
Console.WriteLine("\nINVOICE:" + carRental.Invoice);
>>>>>>> 35db35cca472ca3bffaf6868e93fff7e75a87fde
