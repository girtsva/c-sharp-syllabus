using System;
using System.Collections.Generic;
using System.IO;

namespace WordCount
{
    class Program
    {
        private const string Path = "../../lear.txt"; 
        static void Main(string[] args)
        {
            var lines = new List<string>(File.ReadAllLines(Path));
            
            Console.WriteLine($"Lines = {CountTools.LineCount(lines)}");
            Console.WriteLine($"Words = {CountTools.WordCount(lines)}");
            Console.WriteLine($"Chars = {CountTools.CharCount(lines)}");

            Console.ReadKey();
        }
    }
}
