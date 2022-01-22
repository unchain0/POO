using _200._Herdar_vs._cumprir_contrato.Model.Enums;

namespace _200._Herdar_vs._cumprir_contrato.Model.Entities
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
