using System;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            // On your phone keypad, the alphabets are mapped to digits as follows: ABC(2), DEF(3), GHI(4), JKL(5), MNO(6), PQRS(7), TUV(8), WXYZ(9).
            // Write a program called PhoneKeyPad, which prompts user for text(case insensitive), and converts to a sequence of keypad digits.

            static void PhoneKeyPad()
            {
                Console.WriteLine("Please input the text to be converted to digits. Please note that only letters will be converted...");
                string userText = (Console.ReadLine()).ToLower();

                string convertedText = "";
                int invalidCharCounter = 0;
                for (int i = 0; i < userText.Length; i++)
                {
                    switch (userText[i])
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            convertedText += 2;
                            break;
                        case 'd':
                        case 'e':
                        case 'f':
                            convertedText += 3;
                            break;
                        case 'g':
                        case 'h':
                        case 'i':
                            convertedText += 4;
                            break;
                        case 'j':
                        case 'k':
                        case 'l':
                            convertedText += 5;
                            break;
                        case 'm':
                        case 'n':
                        case 'o':
                            convertedText += 6;
                            break;
                        case 'p':
                        case 'q':
                        case 'r':
                        case 's':
                            convertedText += 7;
                            break;
                        case 't':
                        case 'u':
                        case 'v':
                            convertedText += 8;
                            break;
                        case 'w':
                        case 'x':
                        case 'y':
                        case 'z':
                            convertedText += 9;
                            break;
                        default:
                            invalidCharCounter++;
                            convertedText += " ";
                            break;
                    }
                }

                if (invalidCharCounter > 0)
                {
                    Console.WriteLine($"We have found {invalidCharCounter} non-letters in your text and have converted them to spaces!");
                }

                Console.WriteLine("See the conversion result below:\n" + convertedText);
            }

            PhoneKeyPad();
        }
    }
}
