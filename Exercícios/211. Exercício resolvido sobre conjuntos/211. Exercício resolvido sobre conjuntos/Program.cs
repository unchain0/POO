#pragma warning disable CS8604
#pragma warning disable CS8602
#pragma warning disable CS8600

using _211._Exercício_resolvido_sobre_conjuntos.Entities;

HashSet<LogRecord> set = new();

Console.Write("Enter file full path: "); // C:\temp\in.txt
string path = Console.ReadLine();

try
{
    using StreamReader sr = File.OpenText(path);
    while (!sr.EndOfStream)
    {
        string[] line = sr.ReadLine().Split(' ');
        string name = line[0];
        DateTime instant = DateTime.Parse(line[1]);
        set.Add(new LogRecord { Username = name, Instant = instant });
    }
    Console.WriteLine("Total users: " + set.Count);
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}