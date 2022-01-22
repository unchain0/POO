namespace _201._Herança_múltipla_e_o_problema_do_diamante.Devices
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("ComboDevice print " + document);
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
