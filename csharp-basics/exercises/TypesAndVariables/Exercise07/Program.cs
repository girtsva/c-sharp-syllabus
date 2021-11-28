using System;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prompts the user to enter a string and displays the number of the uppercase letters in the string.

            Console.WriteLine("You will be asked to enter a string of characters.");
            Console.WriteLine("You can use uppercase and lowercase letters and any other characters.");
            Console.WriteLine("The program will show you the number of uppercase letters in your string.");
            Console.WriteLine("Please enter your string:");
            string userString = Console.ReadLine();

            int counter = 0;

            for (int i = 0; i < userString.Length; i++)
            {
                if (char.IsUpper(userString[i]))
                {
                    counter ++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"You have entered {counter} uppercase letters in your string.");
        }
    }
}
