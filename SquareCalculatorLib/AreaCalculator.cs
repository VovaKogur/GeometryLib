using GeometryLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public static class AreaCalculator
    {
        public static double CalculateArea(IShape shape)
        {
           return  shape.CalculateArea();
        }
    }
}
