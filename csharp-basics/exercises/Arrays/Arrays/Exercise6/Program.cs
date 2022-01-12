using System;

namespace Exercise6
{
    public class Program
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

            array1 = FillArrayWithRandomNumbers(array1);

            array2 = CopyArrayValues(array1, array2);

            ChangeLastValue(array1);

            Console.WriteLine($"Array 1: {string.Join(", ", array1)}");
            Console.WriteLine($"Array 2: {string.Join(", ", array2)}");   
        }

        public static int[] FillArrayWithRandomNumbers(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
            }

            return array;
        }

        public static int[] CopyArrayValues(int[] originalArray, int[] copyArray)
        {
            for (int i = 0; i < copyArray.Length; i++)
            {
                copyArray[i] = originalArray[i];
            }

            return copyArray;
        }

        public static void ChangeLastValue(int[] array)
        {
            array[array.Length - 1] = -7;
        }
    }
}
