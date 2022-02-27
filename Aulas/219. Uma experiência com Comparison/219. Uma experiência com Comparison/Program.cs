using _219._Uma_experiência_com_Comparison.Entities;

List<Product> list = new();
// Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

list.Add(new Product("TV", 900.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));

// list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
// list.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
list.Sort(CompareProducts);

foreach (Product p in list)
{
    Console.WriteLine(p);
}

static int CompareProducts(Product p1, Product p2)
{
    // return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
    return p1.Price.CompareTo(p2.Price);
}