using System;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program called CozaLozaWoza which prints the numbers 1 to 110, 11 numbers per line.
             * The program shall print "Coza" in place of the numbers which are multiples of 3, "Loza" for multiples of 5, 
             * "Woza" for multiples of 7, "CozaLoza" for multiples of 3 and 5, and so on. The output shall look like:
             * 
             * 1 2 Coza 4 Loza Coza Woza 8 Coza Loza 11 
             * Coza 13 Woza CozaLoza 16 17 Coza 19 Loza CozaWoza 22 
             * 23 Coza Loza 26 Coza Woza 29 CozaLoza 31 32 Coza
             */

            int startNumber = 1;
            int endNumber = 110;
            string row = "";

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % 105 == 0)
                {
                    row += "CozaLozaWoza ";
                }
                else if (i % 21 == 0)
                {
                    row += "CozaWoza ";
                }
                else if (i % 15 == 0)
                {
                    row += "CozaLoza ";
                }
                else if (i % 7 == 0)
                {
                    row += "Woza ";
                }
                else if (i % 5 == 0)
                {
                    row += "Loza ";
                }
                else if (i % 3 == 0)
                {
                    row += "Coza ";
                }
                else
                {
                    row += i + " ";
                }
                
                if (i % 11 == 0)
                {
                    Console.WriteLine(row);
                    row = "";
                }
            }

            Console.WriteLine(row);
        }
    }
}
