using System.Globalization;

namespace _200._Herdar_vs._cumprir_contrato.Model.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Circle color: {Color}\n" +
                $"Radius = {Radius.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
