using _228_229._LINQ_com_Lambda.Entities;
using System.Globalization;

static void Print<T>(string message, IEnumerable<T> collection) {
    Console.WriteLine(message);
    foreach (T obj in collection) {
        Console.WriteLine(obj);
    }

    Console.WriteLine();
}

Category c1 = new() { Id = 1, Name = "Tools", Tier = 2 };
Category c2 = new() { Id = 2, Name = "Computers", Tier = 1 };
Category c3 = new() { Id = 3, Name = "Electronics", Tier = 1 };

List<Product> products = new()
{
    new Product { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
    new Product { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
    new Product { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
    new Product { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
    new Product { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
    new Product { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
    new Product { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
    new Product { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
    new Product { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
    new Product { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
    new Product { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
};

// IEnumerable<Product>? r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
IEnumerable<Product>? r1 =
    from p in products
    where p.Category.Tier == 1 && p.Price < 900.0
    select p;
Print("TIER 1 AND PRICE < 900.0:", r1);

// IEnumerable<string>? r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
IEnumerable<string>? r2 =
    from p in products
    where p.Category.Name == "Tools"
    select p.Name;
Print("NAME OF PRODUCTS FROM TOOLS:", r2);

// var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
var r3 =
    from p in products
    where p.Name[0] == 'C'
    select new {
        p.Name,
        p.Price,
        CategoryName = p.Category.Name
    };
Print("NAME STARTED WITH 'C' AND ANONYMOUS OBJECT:", r3);

// IEnumerable<Product>? r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
IOrderedEnumerable<Product>? r4 =
    from p in products
    where p.Category.Tier == 1
    orderby p.Name
    orderby p.Price
    select p;
Console.WriteLine("TIER 1 ORDER BY PRICE THEN BY NAME:");
foreach (Product p in r4) {
    Console.WriteLine(p);
}
Console.WriteLine();

// IEnumerable<Product>? r5 = r4.Skip(2).Take(4);
IEnumerable<Product>? r5 =
    (from p in r4
     select p).Skip(2).Take(4);
Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4:", r5);

// Product? r6 = products.FirstOrDefault();
Product? r6 = (from p in products select p).FirstOrDefault();
Console.WriteLine("First or default test1: " + r6);
// Product? r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
Product? r7 = (from p in products
               where p.Price > 3000.0
               select p).FirstOrDefault();
Console.WriteLine("First or default test2: " + r7);
Console.WriteLine();

// Product? r8 = products.Where(p => p.Id == 3).SingleOrDefault();
Product? r8 =
    (from p in products
     where p.Id == 3
     select p).SingleOrDefault();
Console.WriteLine("Single or default test1: " + r8);
// Product? r9 = products.Where(p => p.Id == 30).SingleOrDefault();
Product? r9 =
    (from p in products
     where p.Id == 30
     select p).SingleOrDefault();
Console.WriteLine("Single or default test2: " + r9);
Console.WriteLine();

double r10 = products.Max(p => p.Price);
Console.WriteLine("Max price: $" + r10.ToString("F2", CultureInfo.InvariantCulture));
double r11 = products.Min(p => p.Price);
Console.WriteLine("Min price: $" + r11.ToString("F2", CultureInfo.InvariantCulture));
double r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
Console.WriteLine("Category 1 Sum price: $" + r12.ToString("F2", CultureInfo.InvariantCulture));
double r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
Console.WriteLine("Category 1 Average price: $" + r13.ToString("F2", CultureInfo.InvariantCulture));
double r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine("Category 5 Average price: $" + r14.ToString("F2", CultureInfo.InvariantCulture));
double r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
Console.WriteLine("Category 1 Aggregate sum: $" + r15.ToString("F2", CultureInfo.InvariantCulture));


// IEnumerable<IGrouping<Category, Product>>? r16 = products.GroupBy(p => p.Category);
IEnumerable<IGrouping<Category, Product>>? r16 =
    from p in products
    group p by p.Category;
foreach (IGrouping<Category, Product> group in r16) {
    Console.WriteLine($"\nCategory {group.Key.Name}:");
    foreach (Product p in group) {
        Console.WriteLine(p);
    }
}
