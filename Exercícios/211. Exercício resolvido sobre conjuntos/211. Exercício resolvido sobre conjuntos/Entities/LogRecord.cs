#pragma warning disable CS8618

namespace _211._Exercício_resolvido_sobre_conjuntos.Entities
{
    internal class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is not LogRecord)
            {
                return false;
            }
            LogRecord other = obj as LogRecord;
            return Username.Equals(other.Username);
        }
    }
}
