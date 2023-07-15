using GeometryLib.Interfaces;

namespace GeometryLib.Shapes
{
    public class Trinagle : ITriangle
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;
        public Trinagle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;

            this.sideC = sideC;

        }
        public double CalculateArea()
        {
            double semiP = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiP * (semiP - sideA) * (semiP - sideB) * (semiP - sideC));
        }

        public bool IsRightAngled()
        {
            double[] sidesOfTrinagle = { sideA, sideB, sideC };
            Array.Sort(sidesOfTrinagle);
            return Math.Pow(sidesOfTrinagle[2], 2) == Math.Pow(sidesOfTrinagle[0], 2) + Math.Pow(sidesOfTrinagle[1], 2);
        }
    }
}
