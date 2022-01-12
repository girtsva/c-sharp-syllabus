using System;

namespace Exercise06
{
    public class CozaLozaWoza
    {
        public void PrintResult(int startNumber, int endNumber, int numbersPerLine)
        {
            string row = "";

            for (int i = startNumber; i <= endNumber; i++)
            {
                row += TransformNumber(i) + " ";

                if (i % numbersPerLine == 0)
                {
                    Console.WriteLine(row);
                    row = "";
                }
            }

            Console.WriteLine(row);
        }

        public string TransformNumber(int number)
        {
            string transformed;

            if (number % 7 == 0 && number % 5 == 0 && number % 3 == 0)
            {
                transformed = "CozaLozaWoza";
            }
            else if (number % 7 == 0 && number % 5 == 0)
            {
                transformed = "LozaWoza";
            }
            else if (number % 7 == 0 && number % 3 == 0)
            {
                transformed = "CozaWoza";
            }
            else if (number % 5 == 0 && number % 3 == 0)
            {
                transformed = "CozaLoza";
            }
            else if (number % 7 == 0)
            {
                transformed = "Woza";
            }
            else if (number % 5 == 0)
            {
                transformed = "Loza";
            }
            else if (number % 3 == 0)
            {
                transformed = "Coza";
            }
            else
            {
                transformed = number.ToString();
            }

            return transformed;
        }

    }
}
