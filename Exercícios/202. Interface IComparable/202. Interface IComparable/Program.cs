using _202._Interface_IComparable.Entities;

string path = @"C:\temp\in.txt";

try
{
    using StreamReader sr = File.OpenText(path);
    List<Employee> list = new();

    while (!sr.EndOfStream)
    {
        list.Add(new Employee(sr.ReadLine()));
    }

    list.Sort();
    foreach (Employee emp in list)
    {
        Console.WriteLine(emp);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred\n" + e.Message);
}