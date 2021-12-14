using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            FuelGauge fuelIndicator = new FuelGauge();
            Odometer mileometer = new Odometer(100, fuelIndicator);

            for (int i = 0; i < fuelIndicator.GetTankCapacity(); i++)
            {
                fuelIndicator.AddFuel();
            }

            while(fuelIndicator.AmountOfFuel > 0)
            {
                int mileage = mileometer.AddMileage();

                Console.WriteLine($"Car's current mileage is {mileage}");
                Console.WriteLine($"Car's current amount of fuel is {fuelIndicator.AmountOfFuel}");
                Console.WriteLine("***********************************");
            }

        }
    }
}
