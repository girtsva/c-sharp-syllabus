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

            Console.WriteLine("Guess a randomly generated whole number from 1 to 100 and enter it here: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            if (inputNumber == randomNumber)
            {
                Console.WriteLine("You guessed it right!");
            }
            else if (inputNumber > randomNumber)
            {
                Console.WriteLine("Too high.");
            }
            else
            {
                Console.WriteLine("Too low.");
            }
        }
    }
}
