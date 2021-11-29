using System;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks the user to enter a series of single digit numbers and calculate the sum of all the numbers.

            Console.WriteLine("You will be asked to enter several single digit numbers. Let's proceed...");
            Console.Write("Please enter the first single digit number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second single digit number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter the third single digit number: ");
            int thirdNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter the fourth single digit number: ");
            int fourthNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter the fifth single digit number: ");
            int fifthNum = int.Parse(Console.ReadLine());

            int sumOfNums = firstNum + secondNum + thirdNum + fourthNum + fifthNum;

            Console.WriteLine($"The sum of your entered numbers is: {sumOfNums}");
        }
    }
}
