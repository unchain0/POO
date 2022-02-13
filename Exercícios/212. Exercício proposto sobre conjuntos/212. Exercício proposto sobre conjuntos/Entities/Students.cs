#pragma warning disable CS8600
#pragma warning disable CS8602

namespace _212._Exercício_proposto_sobre_conjuntos.Entities
{
    internal class Students
    {
        public int Registration { get; set; }

        public Students(int registration)
        {
            Registration = registration;
        }

        public override int GetHashCode()
        {
            return Registration.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Students)
            {
                return false;
            }
            Students other = obj as Students;
            return Registration.Equals(other.Registration);
        }
    }
}
