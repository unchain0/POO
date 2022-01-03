string path = @"C:\temp\myfolder\file1.txt";

Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(path)}");
Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar}");
Console.WriteLine($"PathSeparator: {Path.PathSeparator}");
Console.WriteLine($"GetFileName: {Path.GetFileName(path)}");
Console.WriteLine($"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(path)}");
Console.WriteLine($"GetExtension: {Path.GetExtension(path)}");
Console.WriteLine($"GetFullPath: {Path.GetFullPath(path)}");
Console.WriteLine($"GetTempPath: {Path.GetTempPath()}");
