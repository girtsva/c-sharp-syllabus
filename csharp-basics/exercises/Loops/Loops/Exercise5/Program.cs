using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string dots = String.Empty;

            Console.WriteLine("You are asked to enter two words.");
            Console.Write("Please enter the first word: ");
            string firstWord = Console.ReadLine();
            Console.Write("Please enter the second word: ");
            string secondWord = Console.ReadLine();

            for (int i = 0; i < 30 - firstWord.Length - secondWord.Length; i++)
            {
                dots += ".";
            }

            Console.WriteLine();
            Console.WriteLine(firstWord + dots + secondWord);
        }
    }
}
