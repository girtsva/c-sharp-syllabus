using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars = 100;
            int seatsInCar = 4;
            int drivers = 28;
            int passengers = 90;
            int carsFree = 5;
            int carsDriven = cars - carsFree;
            int carpoolCapacity = seatsInCar * drivers;
            double averagePassengersPerCar = Math.Round((double)passengers / drivers, 2);

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("We have cars with " + seatsInCar + " seats only.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsFree + " empty cars and " + carsDriven + " taken cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " passengers to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar + " passengers in each car.");
            Console.ReadKey();
        }
    }
}