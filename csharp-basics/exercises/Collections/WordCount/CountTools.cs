using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCount
{
    public class CountTools
    {
        public static int LineCount(List<string> lines)
        {
            return lines.Count();
        }

        public static int WordCount(List<string> lines)
        {
            int wordCount = 0;

            foreach (var line in lines)
            {
                var separators = new char[] { ' ', '\'' };
                var lineWords = line.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
                wordCount += lineWords.Count();
            }

            return wordCount;
        }

        public static int CharCount(List<string> lines)
        {
            int characterCount = 0;

            foreach (var line in lines)
            {
                characterCount += line.Count();
            }

            return characterCount;
        }
        

        
}
}
