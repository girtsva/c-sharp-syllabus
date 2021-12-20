using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                double result = 1;

                for (int j = 0; j < n; j++)
                {
                    result = i * result;
                }

                Console.WriteLine($"{i} multiplied with itself {n} times or {i}^{n} is {result}");
            }

            Console.ReadKey();
        }
    }
}
