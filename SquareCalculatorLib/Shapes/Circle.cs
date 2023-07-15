using GeometryLib.Interfaces;

namespace GeometryLib.Shapes
{
    public class Circle : ICircle
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
