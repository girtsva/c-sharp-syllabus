using System;

namespace Exercise10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two integers, a min and a max...");
            int minNumber, maxNumber;
            do
            {
                Console.Write("Min? ");

                if (int.TryParse(Console.ReadLine(), out minNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect value entered! Min value must be an integer!");
                }

            } while (true);

            do
            {
                Console.Write("Max? ");

                if (int.TryParse(Console.ReadLine(), out maxNumber) && minNumber <= maxNumber)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect value entered! Max value must an integer and be greater or equal than Min value!");
                }
            } while (true);

            int value = 0;

            for (int i = minNumber; i <= maxNumber; i++)
            {
                for (int j = minNumber; j <= maxNumber; j++)
                {
                    if ((j + value) <= maxNumber)
                    {
                        Console.Write(j + value);
                    }
                    else
                    {
                        Console.Write(j + value - (maxNumber - minNumber + 1));
                    }
                }

                Console.WriteLine();
                value++;
            }
        }
    }
}
