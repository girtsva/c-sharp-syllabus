using System;

namespace Exercise01
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to accept two integers and return true if the either one is 15 or if their sum or difference is 15.

            Console.WriteLine("Enter the first integer value: ");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer value: ");
            int secondInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CheckFifteen(firstInt, secondInt));
        }

        public static bool CheckFifteen(int firstInt, int secondInt)
        {
            return firstInt == 15 || secondInt == 15 || firstInt + secondInt == 15 || firstInt - secondInt == 15 || secondInt - firstInt == 15;
        }
    }
}
