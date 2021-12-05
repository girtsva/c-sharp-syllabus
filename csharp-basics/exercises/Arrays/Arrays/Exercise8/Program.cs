using System;
using System.Text;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] treeNames = {"Apple tree", "Birch", "Cedar", "Cypress", "Eucalyptus", "Hazel", "Juniper", "Maple", "Oak", "Pine", "Willow"};

            var rnd = new Random();

            var word = treeNames[rnd.Next(0, treeNames.Length)];

            var wordToGuess = new string('_', word.Length);
            //string wordToGuess = new StringBuilder("_ ".Length * word.Length).Insert(0, "_ ", word.Length).ToString();
            //Console.WriteLine(str);
            var misses = string.Empty;
            while (!HasGuessed(wordToGuess) && !LimitOfTriesReached(misses))
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine();
                Console.WriteLine($"Word: {wordToGuess}");
                Console.WriteLine();
                Console.WriteLine($"Misses: {misses}");
                Console.WriteLine();
                Console.Write("Guess: ");
                var guess = (Console.ReadKey()).KeyChar;
                Console.WriteLine();
                Console.WriteLine();
                //Console.WriteLine($"Guess: {guess}");

                
                

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

            if(LimitOfTriesReached(misses))
            {
                Console.WriteLine("Five unsuccesful tries reached!");     // principa var to pasu apvienot ar HasGuessed - izdrukat tas pasas rindas, tikai cits message (varbut switch ielikt?), bet ari piedava play again or quit
                Console.WriteLine("GAME OVER!");
                //GameEndChoice();
            }

            if (HasGuessed(wordToGuess))
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine();
                Console.WriteLine($"Word: {wordToGuess}");
                Console.WriteLine();
                Console.WriteLine($"Misses: {misses}");
                Console.WriteLine();

                Console.WriteLine("YOU GOT IT!");
                
                string gameEndChoice;

                do
                {
                    Console.Write("Play \"again\" or \"quit\"? ");
                    gameEndChoice = Console.ReadLine();

                    if (gameEndChoice == "again")
                    {
                        Console.Clear(); // check vai strada korekti - pagaidam liekas, ka console.clear nodzesh ari gameEndChoice vertibu 'again' un liek vienalga ievadit kaut ko
                        //PlayGame();
                    }
                    else if (gameEndChoice == "quit")
                    {
                        Environment.Exit(0);
                    }

                } while (gameEndChoice != "again" || gameEndChoice != "quit");
            }

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
    }
}
