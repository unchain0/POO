#pragma warning disable CS8600
#pragma warning disable CS8602

namespace _207._GetHashCode_e_Equals.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is not Client)
            {
                return false;
            }

            Client other = obj as Client;

            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
