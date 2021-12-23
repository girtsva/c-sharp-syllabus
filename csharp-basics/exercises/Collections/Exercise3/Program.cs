using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> namesList = new HashSet<string>();
            string name;

            while (true)
            {
                Console.Write("Enter a person name (e.g., Bob): ");
                name = Console.ReadLine();

                if (name != "")
                {
                    namesList.Add(name);
                }
                else
                {
                    Console.Write("Unique name list contains: ");
                    Console.WriteLine(string.Join(" ", namesList));
                    break;
                }
            }
        }
    }
}
