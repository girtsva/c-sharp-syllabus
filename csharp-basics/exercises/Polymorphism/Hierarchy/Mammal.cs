using System;

namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        protected string livingRegion;

        public Mammal(string name, string type, double weight, string livingRegion): base(name, type, weight)
        {
            this.livingRegion = livingRegion;
        }

        public override string ToString()
        {
            string specifier = "#,#0.##";
            return $"{GetType().Name}[{animalName}, {animalWeight.ToString(specifier)}, {livingRegion}, {foodEaten}]";
        }
    }
}
