using System;

namespace Hierarchy
{
    public abstract class Animal
    {
        protected string animalName;
        protected string animalType;
        protected double animalWeight;
        protected int foodEaten;

        public Animal(string name, string type, double weight)
        {
            animalName = name;
            animalType = type;
            animalWeight = weight;
        }

        public abstract void MakeSound();

        public abstract void Eat(Food food);

        public override string ToString()
        {
            string specifier = "#,#0.##";
            return $"{GetType().Name}[{animalName}, {animalWeight.ToString(specifier)}, {foodEaten}]";
        }
    }
}
