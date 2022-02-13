#pragma warning disable CS8604

using _212._Exercício_proposto_sobre_conjuntos.Entities;

HashSet<Students> students = new();

try
{
    Console.Write("How many students for course A? ");
    int a = int.Parse(Console.ReadLine());
    for (int i = 0; i < a; i++)
    {
        int registration = int.Parse(Console.ReadLine());
        students.Add(new Students(registration));
    }

    Console.Write("How many students for course B? ");
    int b = int.Parse(Console.ReadLine());
    for (int i = 0; i < b; i++)
    {
        int registration = int.Parse(Console.ReadLine());
        students.Add(new Students(registration));
    }

    Console.Write("How many students for course C? ");
    int c = int.Parse(Console.ReadLine());
    for (int i = 0; i < c; i++)
    {
        int registration = int.Parse(Console.ReadLine());
        students.Add(new Students(registration));
    }

    Console.WriteLine("Total students: " + students.Count);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
