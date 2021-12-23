using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;
            
            Console.WriteLine();

            Car car = new Car(0);
            Car car1 = new Car(0);
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter #{i+1} mileage reading for Car: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading for Car: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car.FillUp(startKilometers, liters);
                Console.WriteLine("Car drived " + car.CalculateConsumption() + " km/l, consumed " + car.CarEconomyClass());
                Console.WriteLine();

                Console.Write($"Enter #{i+1} mileage reading for Car1: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading for Car1: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car1.FillUp(startKilometers, liters);
                Console.WriteLine("Car1 drived " + car1.CalculateConsumption() + " km/l, consumed " + car1.CarEconomyClass());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
