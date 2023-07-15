using GeometryLib;
using GeometryLib.Interfaces;
using GeometryLib.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib_Test
{
    [TestClass]
    public class GeometryLib_Tests
    {
        [TestMethod]
        public void Circle_AreaCalculation()
        {
            double radius = 10;
            double expectedArea = 314.15927;

            Circle circle = new Circle(radius);
            double actualArea = Math.Round(AreaCalculator.CalculateArea(circle), 5, MidpointRounding.AwayFromZero);
            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void Circle_AreaCalculation2()
        {
            double radius = 13;
            double expectedArea = 530.92916;

            Circle circle = new Circle(radius);
            double actualArea = Math.Round(AreaCalculator.CalculateArea(circle), 5, MidpointRounding.AwayFromZero);

            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void Triangle_AreaCalculation()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;

            Trinagle trinagle = new Trinagle(sideA, sideB, sideC);
            double actualArea = AreaCalculator.CalculateArea(trinagle);
            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void Triangle_AreaCalculation2()
        {
            double sideA = 12;
            double sideB = 27;
            double sideC = 19;
            double expectedArea = 99.29753;

            Trinagle trinagle = new Trinagle(sideA, sideB, sideC);
            double actualArea = Math.Round(AreaCalculator.CalculateArea(trinagle), 5, MidpointRounding.AwayFromZero);

            Assert.AreEqual(expectedArea, actualArea);
        }
        [TestMethod]
        public void Trinagle_IsRightAngled_IfRightAngled_ReturnsTrue()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Trinagle triangle = new Trinagle(sideA, sideB, sideC);
           
            bool isRightAngled = triangle.IsRightAngled();
            
            Assert.IsTrue(isRightAngled);
        }
        [TestMethod]
        public void Trinagle_IsRightAngled_IfNotRightAngled_ReturnsFalse()
        {
            double sideA = 9;
            double sideB = 3;
            double sideC = 7;
            Trinagle triangle = new Trinagle(sideA, sideB, sideC);

            bool isRightAngled = triangle.IsRightAngled();

            Assert.IsFalse(isRightAngled);
        }

    }
}
