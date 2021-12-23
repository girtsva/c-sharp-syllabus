using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            double energyDrinkers = Math.Round(CalculateEnergyDrinkers(NumberedSurveyed));
            double preferCitrus = Math.Round(CalculatePreferCitrus(NumberedSurveyed));

            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine("Approximately " + energyDrinkers + " bought at least one energy drink");
            Console.WriteLine(preferCitrus + " of those " + "prefer citrus flavored energy drinks.");
            
            Console.ReadKey();
        }

        public static double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return numberSurveyed * PurchasedEnergyDrinks;
        }

        public static double CalculatePreferCitrus(int numberSurveyed)
        {
            return numberSurveyed * PreferCitrusDrinks;
        }
    }
}
