namespace _201._Herança_múltipla_e_o_problema_do_diamante.Devices
{
    internal abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}
