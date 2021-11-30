using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.Write("Input the 1st number: ");
            var input1 = int.Parse(Console.ReadLine());

            Console.Write("Input the 2nd number: ");
            var input2 = int.Parse(Console.ReadLine());

            Console.Write("Input the 3rd number: ");
            var input3 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (input1 > input2)
            {
                if (input1 > input3)
                {
                    Console.WriteLine($"The 1st number - {input1} is the largest of three numbers.");
                }
                else
                {
                    Console.WriteLine($"The 3rd number - {input3} is the largest of three numbers.");
                }
            }
            else if (input2 > input3)
            {
                Console.WriteLine($"The 2nd number - {input2} is the largest of three numbers.");
            }
            else if (input3 > input2)
            {
                Console.WriteLine($"The 3rd number - {input3} is the largest of three numbers.");
            }
            else
            {
                Console.WriteLine("All three numbers are equal.");
            }

            Console.ReadKey();
        
            /*
            todo - expected output:
            Input the 1st number: 25
            Input the 2nd number: 78
            Input the 3rd number: 87
             */
        }
    }
}
