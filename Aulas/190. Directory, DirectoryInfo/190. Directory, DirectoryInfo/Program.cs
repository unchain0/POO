string path = @"C:\temp\myfolder\";

try
{
    IEnumerable<string>? folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FOLDERS:");
    foreach (string folderItem in folder)
    {
        Console.WriteLine(folderItem);
    }

    IEnumerable<string>? files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("\nFILES:");
    foreach (string file in files)
    {
        Console.WriteLine(file);
    }

    Directory.CreateDirectory(path + "newfolder");
}
catch (IOException e)
{
    Console.WriteLine("An error occurred\n" + e.Message);
}