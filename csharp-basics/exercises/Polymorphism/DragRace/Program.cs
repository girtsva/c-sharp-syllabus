using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

        public static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new Audi());
            cars.Add(new Bmw());
            cars.Add(new Lexus());
            cars.Add(new Subaru());
            cars.Add(new Tesla());
            cars.Add(new Toyota());

            for (int i = 1; i <= 10; i++)
            {
                foreach (var car in cars)
                {
                    if (i == 1)
                    {
                        car.StartEngine();
                    }

                    if (i == 3 && car is IBoostable boostable)
                    {
                        boostable.UseNitrousOxideEngine();
                    }

                    car.SpeedUp();
                }
            }

            Console.WriteLine();
            var fastestSpeed = cars.Max(car => car.ShowCurrentSpeed());
            var fastestCar = "";

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.GetType().Name, -7} {car.ShowCurrentSpeed()} km/h");

                if (car.ShowCurrentSpeed() == fastestSpeed)
                {
                    fastestCar = car.GetType().Name;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"{fastestCar} is the fastest car having reached speed {fastestSpeed} km/h");
        }
    }
}