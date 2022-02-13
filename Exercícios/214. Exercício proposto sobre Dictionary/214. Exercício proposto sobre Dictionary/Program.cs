#pragma warning disable CS8604
#pragma warning disable CS8602

Dictionary<string, int> log = new();

Console.Write("Enter file full path: "); // c:\temp\in.txt
string path = Console.ReadLine();

try
{
    using StreamReader sr = File.OpenText(path);
    while (!sr.EndOfStream)
    {
        string[] line = sr.ReadLine().Split(',');
        string name = line[0];
        int whises = int.Parse(line[1]);

        if (log.ContainsKey(name))
        {
            log[name] += whises;
        }
        else
        {
            log.Add(name, whises);
        }
    }
    foreach (KeyValuePair<string, int> item in log)
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
