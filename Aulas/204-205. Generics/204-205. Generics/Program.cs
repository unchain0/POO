#pragma warning disable CS8604

using _204_205._Generics;

PrintService<int> ps = new();

Console.Write("How many values? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    ps.AddValue(int.Parse(Console.ReadLine()));
}

ps.Print();
Console.WriteLine("First: " + ps.First());