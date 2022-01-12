using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();

            var line = Console.ReadLine();

            while (line != "End")
            {
                var animalInfo = line.Split();
                var animalType = animalInfo[0];

                if (animalType == "Mouse")
                {
                    animals.Add(new Mouse(animalInfo[1], animalInfo[0], double.Parse(animalInfo[2]), animalInfo[3]));
                }
                else if (animalType == "Zebra")
                {
                    animals.Add(new Zebra(animalInfo[1], animalInfo[0], double.Parse(animalInfo[2]), animalInfo[3]));
                }
                else if (animalType == "Cat")
                {
                    animals.Add(new Cat(animalInfo[1], animalInfo[0], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]));
                }
                else if (animalType == "Tiger")
                {
                    animals.Add(new Tiger(animalInfo[1], animalInfo[0], double.Parse(animalInfo[2]), animalInfo[3]));
                }

                animals[animals.Count - 1].MakeSound();

                var foodInfo = Console.ReadLine().Split();
                var foodType = foodInfo[0];
                var foodQuantity = int.Parse(foodInfo[1]);
                Food givenFood;

                if (foodType == "Meat")
                {
                    givenFood = new Meat(foodQuantity);
                }
                else
                {
                    givenFood = new Vegetable(foodQuantity);
                }

                try
                {
                    animals[animals.Count - 1].Eat(givenFood);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }


                Console.WriteLine(animals[animals.Count - 1].ToString());

                line = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Information on all received animals:");

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}