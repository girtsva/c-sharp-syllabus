using System;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Use several variables to store the names of your classes and their teachers.
             * Then, display a nice little table displaying your schedule. FYI, my column of 
             * courses has a width of 26 characters, and the teacher column has a width of 15. 
             * The first and last lines are a plus sign, fifty dashes (a.k.a. minus signs) and 
             * another plus sign.
             */

            string[,] schedule = new string[8, 2]
            {
                {"English III", "Ms. Lapan"},
                {"Precalculus", "Mrs. Gideon"},
                {"Music Theory", "Mr. Davis"},
                {"Biotechnology", "Ms. Palmer"},
                {"Principles of Technology I", "Ms. Garcia"},
                {"Latin II", "Mrs. Barnett"},
                {"AP US History", "Ms. Johannessen"},
                {"Business Computer Infomation Systems", "Mr. James"}
            };

            string row = "";
            string dashes = new string('-', 60);
            int colDivider = 43;
            int charsPerLine = 62 - 1;

            Console.WriteLine("+" + dashes + "+");

            for (int rowInd = 0; rowInd < schedule.GetLength(0); rowInd++)
            {
                row = "";
                row += "| " + (rowInd + 1) + " |";
                for (int colInd = 0; colInd < schedule.GetLength(1); colInd++)
                {
                    row += " " + schedule[rowInd, colInd];
                    if (colInd == 0)
                    {
                        string spaces = new string(' ', colDivider - row.Length);
                        row += spaces;
                        row += "|";
                    }
                    else
                    {
                        string spaces = new string(' ', charsPerLine - row.Length);
                        row += spaces;
                        row += "|";
                    }
                }
                Console.WriteLine(row);
            }
            Console.WriteLine("+" + dashes + "+");
        }
    }
}
