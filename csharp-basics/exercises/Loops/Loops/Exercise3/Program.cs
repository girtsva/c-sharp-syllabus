using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks which number position out of 20 random numbers you want to know.

            Console.Write("Which number position (1 - 20) out of 20 random numbers do you want to know? ");
            int numberPosition = int.Parse(Console.ReadLine());

            int[] randomNumbers = new int[20];

            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                randomNumbers[i] = rnd.Next();
            }

            Console.WriteLine($"Random number on position {numberPosition} is {randomNumbers[numberPosition -1]}");
        }
    }
}
