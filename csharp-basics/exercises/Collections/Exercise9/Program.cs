using System;
using System.Collections.Generic;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashset = new HashSet<string>();

            hashset.Add("One");
            hashset.Add("Two");
            hashset.Add("Three");
            hashset.Add("Four");
            hashset.Add("Five");

            foreach (var item in hashset)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");

            hashset.Clear();

            hashset.Add("Four");
            hashset.Add("Four");
            hashset.Add("Four");

            foreach (var item in hashset)
            {
                Console.WriteLine(item);
            }
        }
    }
}
