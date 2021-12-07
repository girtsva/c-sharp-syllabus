using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program called PrintDayInWord which prints “Sunday”, “Monday”, ... “Saturday” if the
            // int variable "dayNumber"is 0, 1, ..., 6, respectively. Otherwise, it shall print "Not a valid day".

            Console.Write("Type in the weekday number (0 - 7): ");
            string userWeekday = Convert.ToString(Console.ReadKey().KeyChar);
            Console.WriteLine();

            static void PrintDayInWord(string symbol)
            {
                if (int.TryParse(symbol, out int weekday) && weekday > 0 && weekday < 8)
                {
                    if (weekday == 1)
                    {
                        Console.WriteLine("Monday");
                    }
                    else if (weekday == 2)
                    {
                        Console.WriteLine("Tuesday");
                    }
                    else if (weekday == 3)
                    {
                        Console.WriteLine("Wednesday");
                    }
                    else if (weekday == 4)
                    {
                        Console.WriteLine("Thursday");
                    }
                    else if (weekday == 5)
                    {
                        Console.WriteLine("Friday");
                    }
                    else if (weekday == 6)
                    {
                        Console.WriteLine("Saturday");
                    }
                    else
                    {
                        Console.WriteLine("Sunday");
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid day!");
                }
            }

            PrintDayInWord(userWeekday);
        }
    }
}
