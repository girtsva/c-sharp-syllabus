using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that creates an array of ten integers. It should put ten random numbers from 1 to 100 in the array.
             * It should copy all the elements of that array into another array of the same size. Then display the contents of both
             * arrays. To get the output to look like this, you'll need a several for loops.
             * - Create an array of ten integers
             * - Fill the array with ten random numbers (1-100)
             * - Copy the array into another array of the same capacity
             * - Change the last value in the first array to a -7
             * - Display the contents of both arrays
             */

            int[] array1 = new int[10];
            int[] array2 = new int[10];

            for (int i = 0; i < array1.Length; i++)
            {
                Random rnd = new Random();
                array1[i] = rnd.Next(1, 101);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array1[i];
            }

            array1[array1.Length - 1] = -7;

            Console.WriteLine($"Array 2: {string.Join(", ", array1)}");
            Console.WriteLine($"Array 2: {string.Join(", ", array2)}");   
        }
    }
}
