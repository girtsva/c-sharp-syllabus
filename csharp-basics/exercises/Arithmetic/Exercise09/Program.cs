using System;

namespace Exercise09
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that calculates and displays a person's body mass index (BMI). A person's BMI is calculated with the following formula: BMI = weight x 703 / height ^ 2.
             * Where weight is measured in pounds and height is measured in inches. Display a message indicating whether the person has optimal weight, is underweight, or is overweight.
             * A sedentary person's weight is considered optimal if his or her BMI is between 18.5 and 25. If the BMI is less than 18.5, the person is considered underweight.
             * If the BMI value is greater than 25, the person is considered overweight. Your program must accept metric units.
             */

            Console.Write("Please specify your weight in kg: ");
            var weightInPounds = Convert.ToDouble(Console.ReadLine()) * 2.2046;
            Console.Write("Please specify your height in cm: ");
            var heightInInches = Convert.ToDouble(Console.ReadLine()) / 2.54;

            var BMI = Math.Round(weightInPounds * 703 / Math.Pow(heightInInches, 2), 2);

            if (BMI >= 18.5 && BMI <= 25)
            {
                Console.WriteLine($"Your BMI is {BMI}, your weight is OPTIMAL. The optimal reference interval is 18.5 - 25.");
            }
            else if (BMI < 18.5)
            {
                Console.WriteLine($"Your BMI is {BMI}, your weight is UNDERWEIGHT. The optimal reference interval is 18.5 - 25.");
            }
            else
            {
                Console.WriteLine($"Your BMI is {BMI}, your weight is OVERWEIGHT. The optimal reference interval is 18.5 - 25.");
            }  
        }
    }
}
