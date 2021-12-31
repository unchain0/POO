#pragma warning disable CS8600
#pragma warning disable CS8604

using _123._Exercício_proposto.Entities;
using _123._Exercício_proposto.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter client data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine(birthDate);

Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());
Console.Write("How many items to this order? ");
int items = int.Parse(Console.ReadLine());

Client client = new(name, email, birthDate);
Order order = new(DateTime.Now, os, client);

for (int i = 1; i <= items; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string pName = Console.ReadLine();
    Console.Write("Product price: ");
    double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    Product product = new(pName, pPrice);
    OrderItem item = new(quantity, pPrice, product);
    order.AddItem(item);
}

Console.WriteLine(order);