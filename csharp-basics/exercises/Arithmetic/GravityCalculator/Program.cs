
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var gravityCal = new GravityCalculator();
            Console.WriteLine(gravityCal.ShowNewObjectPosition());
            Console.ReadKey();
        }
    }
}
