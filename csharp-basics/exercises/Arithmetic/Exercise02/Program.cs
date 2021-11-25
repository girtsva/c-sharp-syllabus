using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program called CheckOddEven which prints "Odd Number" if the int variable “number” is odd, or “Even Number” otherwise. The program shall always print “bye!” before exiting.

            Console.WriteLine("Enter the integer value: ");
            int inputInt = Convert.ToInt32(Console.ReadLine());
            
            static void CheckOddEven(int inputInt)
            {
                if(inputInt % 2 == 0)
                {
                    Console.WriteLine("Even Number");
                }
                else
                {
                    Console.WriteLine("Odd Number");
                }
            }

            CheckOddEven(inputInt);
            Console.WriteLine("bye!");
        }
    }
}
