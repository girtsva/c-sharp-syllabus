using System;

namespace Exercise8
{
    class AsciiFigure
    {
        static void Main(string[] args)
        {
            const int numberOfRows = 5;

            double rowLength = (numberOfRows - 3)/2.0 * 16 + 16;
            double midline = rowLength / 2;
            int stepLength = 4;

            for (int rowInd = 0; rowInd < numberOfRows; rowInd++)
            {
                string row = "";

                for (int colInd = 0; colInd < rowLength; colInd++)
                {                    
                    if (colInd < midline - stepLength * rowInd)
                    {
                        row += "/";
                    }
                    else if (colInd >= midline + stepLength * rowInd)
                    {
                        row += "\\";
                    }
                    else 
                    {
                        row += "*";
                    }
                }

                Console.WriteLine(row);
            }
        }
    }
}
