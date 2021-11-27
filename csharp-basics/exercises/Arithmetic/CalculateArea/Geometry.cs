using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            if (radius < 0)
            {
                Console.WriteLine("Radius cannot be less than 0!");
                return 0;
            }
            else
            {
                double area = Math.PI * Convert.ToDouble(radius) * 2;
                return area;
            } 
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            if (length < 0 || width < 0)
            {
                Console.WriteLine($"Length or width cannot be less than 0! You specified length as {length} and width as {width}.");
                return 0;
            }
            else
            {
                double area = Convert.ToDouble(length) * Convert.ToDouble(width);
                return area;
            }
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            if (ground < 0 || h < 0)
            {
                Console.WriteLine($"Base or height cannot be less than 0! You specified base as {ground} and height as {h}.");
                return 0;
            }
            else
            {
                double area = Convert.ToDouble(ground) * Convert.ToDouble(h) * 0.5;
                return area;
            }
        }
    }
}
