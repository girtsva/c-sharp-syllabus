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

            var wordToGuess = new string('_', word.Length);
            //string wordToGuess = new StringBuilder("_ ".Length * word.Length).Insert(0, "_ ", word.Length).ToString();
            //Console.WriteLine(wordToGuess);
            var misses = string.Empty;
            while (!HasGuessed(wordToGuess) && !LimitOfTriesReached(misses))
            {
                PrintWordAndMisses(wordToGuess, misses);

                Console.Write("Guess: ");
                var guess = (Console.ReadKey()).KeyChar;
                Console.WriteLine();
                Console.WriteLine();
                //Console.WriteLine($"Guess: {guess}");

                //CheckIfGuessed(word, guess, wordToGuess, misses);

                if (WordContains(word, guess))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word.ToLower()[i] == guess)
                        {
                            var sb = new StringBuilder(wordToGuess);
                            sb[i] = word[i];
                            wordToGuess = sb.ToString();
                        }
                    }
                }
                else
                {
                    misses += guess;
                }
            }

            IsGameOver(word, wordToGuess, misses);
        }

        public static bool WordContains(string word, char guess)
        {
            return word.ToLower().IndexOf(guess) > -1;
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

        public static void IsGameOver(string word, string wordToGuess, string misses)
        {
            PrintWordAndMisses(wordToGuess, misses);

            if (LimitOfTriesReached(misses))
            {
                Console.WriteLine($"Five unsuccesful tries reached! The word you did not guess was \"{word}\"");
            }
            else if (HasGuessed(wordToGuess))
            {
                Console.WriteLine("YOU GOT IT!");
            }

            Console.WriteLine("GAME OVER!");

            GameEndChoice();
        }

        public static void CheckIfGuessed(string word, char guess, string wordToGuess, string misses)
        {
            if (WordContains(word, guess))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word.ToLower()[i] == guess)
                    {
                        var sb = new StringBuilder(wordToGuess);
                        sb[i] = word[i];
                        wordToGuess = sb.ToString();
                    }
                }
                //Console.WriteLine(wordToGuess);//return wordToGuess;
            }
            else
            {
                misses += guess;
                //Console.WriteLine(misses);// return misses;
            }
        }
    }
}
