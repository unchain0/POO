using _201._Herança_múltipla_e_o_problema_do_diamante.Devices;

Printer p = new() { SerialNumber = 1080 };
p.ProcessDoc("My letter");
p.Print("My letter");
Console.WriteLine();
Scanner s = new() { SerialNumber = 2003 };
s.ProcessDoc("My email");
Console.WriteLine(s.Scan());
Console.WriteLine();
ComboDevice c = new() { SerialNumber = 3921 };
c.ProcessDoc("My dissertation");
c.Print("My dissertation");
Console.WriteLine(c.Scan());
