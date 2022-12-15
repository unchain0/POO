using _123._Exercício_proposto.Entities.Enums;
using System.Globalization;
using System.Text;

namespace _123._Exercício_proposto.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; } = new();
        public List<OrderItem> Items { get; private set; } = new();

        public Order()
        {   
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("\nORDER SUMMARY");
            sb.AppendLine($"Order moment: {DateTime.Now}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate:dd/MM/yyyy}) - {Client.Email}");
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine($"{item.Product.Name}, ${item.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            sb.AppendLine($"Total price: {Total()}");

            return sb.ToString();
        }
    }
}
