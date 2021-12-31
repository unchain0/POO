using _115._Enumerações.Entities;
using _115._Enumerações.Entities.Enums;

Order order = new()
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);
Console.WriteLine();

string txt = OrderStatus.PendingPayment.ToString();

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(os);
Console.WriteLine(txt);