using System;

namespace Exercise02
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Write a program called CheckOddEven which prints "Odd Number" if the int variable “number” is odd, or “Even Number” otherwise. The program shall always print “bye!” before exiting.

            Console.WriteLine("Enter the integer value: ");
            int inputInt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CheckOddEven(inputInt));
            Console.WriteLine("bye!");
        }

        public static string CheckOddEven(int inputInt)
        {
            return inputInt % 2 == 0 ? "Even Number" : "Odd Number";
        }
    }
}
