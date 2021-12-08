using System;

namespace Exercise9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your desired sum of two dice rolls (integers 2-12)...");
            int userChoice;
            do
            {
                Console.Write("Desired sum: ");
                if (int.TryParse(Console.ReadLine(), out userChoice) && userChoice >= 2 && userChoice <= 12)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect value entered! Please enter any integer between 2 and 12!");
                }
            } while (true);
            
            Random rnd = new Random();
            int sumOfRolls;

            do
            {
                int diceRoll1 = rnd.Next(1, 7);
                int diceRoll2 = rnd.Next(1, 7);
                sumOfRolls = diceRoll1 + diceRoll2;

                Console.WriteLine($"{diceRoll1} and {diceRoll2} = {sumOfRolls}");

            } while (sumOfRolls != userChoice);

        }
    }
}
