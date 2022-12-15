namespace _70_Vetores_PARTE_2
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

        public static double Average(double sum, int n)
        {
            return sum / n;
        }
    }
}
