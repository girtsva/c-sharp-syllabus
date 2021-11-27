using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that stores your name and year of birth into variables, and displays their values on the screen.
             * Make sure that you use two variables, and that the variable that holds your name is the best type for such a variable,
             * and that the variable that holds the year is the best type for that variable.
             * Also make sure that your variable names are good: the name of a variable should always relate to its contents.
             * Output example: My name is Juan Valdez and I was born in 1995.
             */

            string name = "Girts Varna";
            int birthYear = 1982;

            Console.WriteLine($"My name is {name} and I was born in {birthYear}");
        }
    }
}
