using System;

namespace Exercise09
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);

            SwapPoints(p1, p2);

            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
        }

        public static void SwapPoints(Point p1, Point p2)
        {
            Point temporary = new Point(p1.X, p1.Y);
            p1.X = p2.X;
            p1.Y = p2.Y;
            p2.X = temporary.X;
            p2.Y = temporary.Y;
            temporary = null;
            GC.Collect();
        }
    }
}
