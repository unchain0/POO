#region Primeiro Exemplo
DateTime dt = new(2022, 2, 13, 8, 10, 45);
Console.WriteLine(dt.ElapsedTime());
Console.WriteLine();
#endregion

#region Segundo Exemplo
string s1 = "Good morning dear students!";
Console.WriteLine(s1.Cut(27));
Console.WriteLine(s1.Cut(12));
Console.WriteLine(s1.Cut(32));
#endregion
