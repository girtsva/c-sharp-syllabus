using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            bool endGame;
            Random rnd = new Random();
            int points = 0;

            do
            {
                int diceRoll = rnd.Next(1, 7);
                Console.WriteLine($"You rolled a {diceRoll}");
                points += diceRoll;

                if (diceRoll == 1)
                {
                    points = 0;
                    endGame = EndGame(points);
                }
                else
                {
                    char rollChoice;
                    do
                    {
                    Console.Write("Roll again? (y/n) ");
                    rollChoice = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (rollChoice == 'y')
                    {
                        endGame = false;
                        break;
                    }
                    else if (rollChoice == 'n')
                    {
                        endGame = EndGame(points);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input!");
                    }
                    } while (true);
                }

            } while (!endGame) ;
        }

        static bool EndGame(int points)
        {
            Console.WriteLine($"You got {points} points.");
            return true;
        }
    }
}
