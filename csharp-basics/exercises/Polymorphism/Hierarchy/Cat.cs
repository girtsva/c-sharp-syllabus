using System;

namespace Hierarchy
{
    public class Cat : Feline
    {
        private string _breed;

        public Cat(string name, string type, double weight, string livingRegion, string breed) : base(name, type, weight, livingRegion)
        {
            _breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("..Meowwww..");
        }

        public override void Eat(Food food)
        {
            foodEaten += food.Quantity;
        }

        public override string ToString()
        {
            string specifier = "#,#0.##";
            return $"{GetType().Name}[{animalName}, {_breed}, {animalWeight.ToString(specifier)}, {livingRegion}, {foodEaten}]";
        }
    }
}
