using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        private const string Path = "../../lear.txt"; 
        static void Main(string[] args)
        {
            int lineCount;
            int wordCount = 0;
            int characterCount = 0;
            
            var lines = new List<string>(File.ReadAllLines(Path));
            lineCount = lines.Count();

            List<string> lineWords = new List<string>();

            foreach (var line in lines)
            {
                characterCount += line.Count();

                char[] separators = new char[] { ' ', '\'' };
                lineWords = line.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
                wordCount += lineWords.Count();
            }

            Console.WriteLine($"Lines = {lineCount}");
            Console.WriteLine($"Words = {wordCount}");
            Console.WriteLine($"Chars = {characterCount}");
            
            Console.ReadKey();
        }
    }
}
