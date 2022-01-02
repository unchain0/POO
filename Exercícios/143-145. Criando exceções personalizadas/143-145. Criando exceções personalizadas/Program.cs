#pragma warning disable CS8604

using _143_145._Criando_exceções_personalizadas.Entities;
using _143_145._Criando_exceções_personalizadas.Entities.Exceptions;

try
{
    Console.Write("Room number: ");
    int roomNumber = int.Parse(Console.ReadLine());
    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new(roomNumber, checkIn, checkOut);
    Console.WriteLine($"Reservation: {reservation}");


    Console.WriteLine("Enter data to update the reservation:");
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(checkIn, checkOut);
    Console.WriteLine($"Reservation: {reservation}");
}
catch (FormatException e)
{
    Console.WriteLine("Error in format: " + e.Message);
}
catch (DomainException e)
{
    Console.WriteLine("Error in reservation: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unexpected error: " + e.Message);
}