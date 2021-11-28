using System;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to convert minutes into a number of years and days.

            Console.WriteLine("Please enter a number of minutes and we will calculate this into a number of years and days: \n");
            decimal minutes = Convert.ToDecimal(Console.ReadLine());

            decimal minutesInDay = 60 * 24;
            decimal minutesInYear = 365 * minutesInDay;

            decimal minutesToYears = minutes / minutesInYear;

            if (minutesToYears >= 1)
            {
                decimal minutesToDays = Math.Round(minutes % minutesInYear / minutesInDay, 6);
                minutesToYears = Math.Floor(minutesToYears);
                Console.WriteLine($"\nYour entered number of minutes is {minutesToYears} years and {minutesToDays} days.");
            }
            else
            {
                decimal minutesToDays = Math.Round(minutes / minutesInDay, 6);
                minutesToYears = Math.Round(minutesToYears, 6);
                Console.WriteLine($"\nYour entered number of minutes is {minutesToYears} years or {minutesToDays} days.");
            }

         



        }
    }
}
