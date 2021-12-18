using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();
            int number;

            while(!int.TryParse(input, out number))
            {
                Console.Write("This is not an integer! Enter again: ");
                input = Console.ReadLine();
            }

            while (number != 1 && number != 4)
            {
                string str = number.ToString();
                List<int> digits = new List<int>();

                foreach (char digit in str)
                {
                    digits.Add(Convert.ToInt32(digit.ToString()));
                }

                number = 0;
                for (int i = 0; i < digits.Count; i++)
                {
                    digits[i]*= digits[i];
                    number += digits[i];
                }
            }
            
            if (number == 1)
            {
                Console.WriteLine($"Integer {input} is \"happy\", as summing the squares of its digits eventually leads to {number}!");
            }
            else
            {
                Console.WriteLine($"Integer {input} is \"NOT happy\", as summing the squares of its digits eventually leads to {number}!");
            }
        }
    }
}
