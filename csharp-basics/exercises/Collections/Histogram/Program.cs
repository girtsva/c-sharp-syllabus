using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var examScores = new List<int>();
            var histogramRows = new int[11];
            
            var readText = File.ReadAllLines(Path);
            foreach (var line in readText)
            {
                examScores = line.Split(' ').ToList().ConvertAll(score => Int32.Parse(score));
            }

            for (int i = 0; i < examScores.Count; i++)
            {
                if (examScores[i] < 0 || examScores[i] > 100)
                {
                    Console.WriteLine("Invalid scores! File contains scores < 0 or > 100!");
                    break;
                }
                else
                {
                    var range = examScores[i] / 10;
                    histogramRows[range]++;
                }
            }

            for (int i = 0; i < histogramRows.Length; i++)
            {
                var range = "";
                var asterisks = "";

                if (i == 0)
                {
                    range = "00-09";
                }
                else if (i == 10)
                {
                    range = "  100";
                }
                else
                {
                    range = (10 * i) + "-" + (10 * i + 9);
                }

                asterisks = new string('*', histogramRows[i]);

                Console.WriteLine($"{range}: {asterisks}");
            }

            Console.ReadKey();
        }
    }
}
