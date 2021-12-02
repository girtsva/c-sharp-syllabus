using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            return Math.PI * Convert.ToDouble(radius) * 2;
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            return Convert.ToDouble(length) * Convert.ToDouble(width);
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            return Convert.ToDouble(ground) * Convert.ToDouble(h) * 0.5;
        }
    }
}
