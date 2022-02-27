using System.Globalization;

namespace _223._Predicate__exemplo_com_RemoveAll_.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
