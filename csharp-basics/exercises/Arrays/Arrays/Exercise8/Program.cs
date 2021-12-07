using System;
using System.Text;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();
        }

        public static void PlayGame()
        {
            string[] treeNames = { "Apple tree", "Birch", "Cedar", "Cypress", "Eucalyptus", "Hazel", "Juniper", "Maple", "Oak", "Pine", "Willow" };

            var rnd = new Random();
            var word = treeNames[rnd.Next(0, treeNames.Length)];

            var result = new GuessOutput();
            result.WordToGuess = new string('_', word.Length);
            result.Misses = string.Empty;

            while (!HasGuessed(result.WordToGuess) && !LimitOfTriesReached(result.Misses))
            {
                PrintWordAndMisses(result.WordToGuess, result.Misses);

                Console.Write("Guess: ");
                var guess = (Console.ReadKey()).KeyChar;
                Console.WriteLine();
                Console.WriteLine();

                CheckIfGuessed(word, guess, result);

            }

            IsGameOver(word, result);
        } 

        public static bool HasGuessed(string wordToGuess)
        {
            return wordToGuess.IndexOf('_') == -1;
        }

        public static bool LimitOfTriesReached(string misses)
        {
            return misses.Length == 5;
        }

        public static void PrintWordAndMisses(string wordToGuess, string misses)
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine();
            Console.WriteLine($"Word: {wordToGuess}");
            Console.WriteLine();
            Console.WriteLine($"Misses: {misses}");
            Console.WriteLine();
        }

        public static void CheckIfGuessed(string word, char guess, GuessOutput result)
        {
            if (WordContains(word, guess))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word.ToLower()[i] == guess)
                    {
                        var sb = new StringBuilder(result.WordToGuess);
                        sb[i] = word[i];
                        result.WordToGuess = sb.ToString();
                    }
                }
            }
            else
            {
                result.Misses += guess;
            }
        }

        public static bool WordContains(string word, char guess)
        {
            return word.ToLower().IndexOf(guess) > -1;
        }

        public static void IsGameOver(string word, GuessOutput result)
        {
            PrintWordAndMisses(result.WordToGuess, result.Misses);

            if (LimitOfTriesReached(result.Misses))
            {
                Console.WriteLine($"\nFive unsuccesful tries reached! The word you did not guess was \"{word}\"\n");
            }
            else if (HasGuessed(result.WordToGuess))
            {
                Console.WriteLine("\nYOU GOT IT!\n");
            }

            Console.WriteLine("GAME OVER!\n");

            GameEndChoice();
        }

        public static void GameEndChoice()
        {
            string gameEndChoice;

            do
            {
                Console.Write("Play \"again\" or \"quit\"? ");
                gameEndChoice = Console.ReadLine();

                if (gameEndChoice == "again")
                {
                    Console.Clear();
                    gameEndChoice = "again";
                    PlayGame();
                }
                else if (gameEndChoice == "quit")
                {
                    Environment.Exit(0);
                }

            } while (gameEndChoice != "again" || gameEndChoice != "quit");
        }
    }

    public class GuessOutput
    {
        public string WordToGuess { get; set; }
        public string Misses { get; set; }
    }
}
