using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Zed A. Shaw";
            int age = 35;
            double heightInCm = Math.Round(74 * 2.54);
            double weightInKg = Math.Round(180 * 0.453592, 2);
            string eyeColor = "Blue";
            string teethColor = "White";
            string hairColor = "Brown";

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + heightInCm + " centimetres tall.");
            Console.WriteLine("He's " + weightInKg + " kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyeColor + " eyes and " + hairColor + " hair.");
            Console.WriteLine("His teeth are usually " + teethColor + " depending on the coffee.");
            Console.WriteLine("If I add his age " + age + ", his height " + heightInCm + ", and his weight " + weightInKg
                               + " I get " + (age + heightInCm + weightInKg) + ".");
            Console.ReadKey();
        }
    }
}