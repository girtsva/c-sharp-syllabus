using System;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that picks a random number from 1-100. Give the user a chance to guess it.
             * If they get it right, tell them so. If their guess is higher than the number, say "Too high."
             * If their guess is lower than the number, say "Too low." Then quit. (They don't get any more guesses for now.)
             */

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);

            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            if (inputNumber == randomNumber)
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
            else if (inputNumber > randomNumber)
            {
                Console.WriteLine($"Sorry, you are too high. I was thinking of {randomNumber}.");
            }
            else
            {
                Console.WriteLine($"Sorry, you are too low. I was thinking of {randomNumber}.");
            }
        }
    }
}
