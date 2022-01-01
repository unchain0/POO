using _136._Exercício_resolvido__métodos_abstratos_.Entities.Enums;

namespace _136._Exercício_resolvido__métodos_abstratos_.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color)
            : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            const double pi = 3.14159265358979323846;
            return pi * Math.Pow(Radius, 2);
        }
    }
}
