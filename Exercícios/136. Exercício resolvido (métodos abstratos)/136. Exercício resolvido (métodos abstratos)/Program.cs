using _136._Exercício_resolvido__métodos_abstratos_.Entities;
using _136._Exercício_resolvido__métodos_abstratos_.Entities.Enums;
using System.Globalization;

List<Shape> shape = new();

Console.Write("Enter the number of shapes: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write($"Shape #{i} data:\nRectangle or Circle (r/c)? ");
    char option = char.Parse(Console.ReadLine());
    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());

    if (option == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Rectangle rectangle = new(width, height, color);
        shape.Add(rectangle);
    }

    else if (option == 'c')
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Circle circle = new(radius, color);
        shape.Add(circle);
    }
}

Console.WriteLine("\nSHAPE AREAS:");
foreach (Shape s in shape)
{
    Console.WriteLine(s.Area().ToString("F2", CultureInfo.InvariantCulture));
}