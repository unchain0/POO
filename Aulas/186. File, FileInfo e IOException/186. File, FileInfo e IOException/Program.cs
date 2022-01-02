string sourcePath = @"C:\temp\file1.txt";
string targetPath = @"c:\temp\file2.txt";

try
{
    FileInfo fileInfo = new(sourcePath);
    fileInfo.CopyTo(targetPath);

    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred\n" + e.Message);
    FileInfo deleteFile = new(targetPath);
    deleteFile.Delete();
}