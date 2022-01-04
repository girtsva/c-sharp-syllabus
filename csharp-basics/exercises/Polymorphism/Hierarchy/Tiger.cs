using System;

namespace Hierarchy
{
    public class Tiger : Feline
    {

        public Tiger(string name, string type, double weight, string livingRegion) : base(name, type, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("..ROAAR..");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
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
