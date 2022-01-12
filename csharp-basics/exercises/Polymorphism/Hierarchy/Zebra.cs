using System;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string name, string type, double weight, string livingRegion) : base(name, type, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("..kwa-ha-ah-eh-kwa-ha-ah..");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                throw new ArgumentException($"{GetType().Name}s are not eating that type of food!");
            }
            else
            {
                foodEaten += food.Quantity;
            }
        }
    }
}
