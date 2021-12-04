using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program called Product1ToN to compute the product of integers from 1 to 10 (i.e., 1×2×3×...×10), as an int. Take not that It is the same as factorial of N.

            static int Product1ToN(int n)
            {
                int factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }

                return factorial;
            }

            Console.WriteLine(Product1ToN(10));
        }
    }
}
