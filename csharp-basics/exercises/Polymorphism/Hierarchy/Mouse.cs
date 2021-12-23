using System;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string name, string type, double weight, string livingRegion) : base(name, type, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("..squeak squeak..");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                Console.WriteLine($"{GetType().Name}s are not eating that type of food!");
            }
            else
            {
                foodEaten += food.Quantity;
            }
        }
    }
}
