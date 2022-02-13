using _207._GetHashCode_e_Equals.Entities;

Client a = new()
{
    Name = "Maria",
    Email = "maria@gmail.com"
};

Client b = new()
{
    Name = "Alex",
    Email = "maria@gmail.com"
};

Console.WriteLine(a.Equals(b));
Console.WriteLine(a == b);
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());