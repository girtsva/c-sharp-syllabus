using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);

            var departureCities = new HashSet<string>();
            var destinationCities = new HashSet<string>();

            foreach (var line in readText)
            {
                var cities = line.Split('-');
                cities[0] = cities[0].Trim();
                departureCities.Add(cities[0]);
                cities[1] = cities[1].Replace("> ", "");
                destinationCities.Add(cities[1]);
            }

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("To display list of the starting departure cities press 1");
            Console.WriteLine("To exit program press #");
            char userChoice = (Console.ReadKey()).KeyChar;
            Console.WriteLine();
            Console.WriteLine();

            if (userChoice == '1')
            {
                foreach (var city in departureCities)
                {
                    Console.WriteLine("- " + city);
                }
                Console.WriteLine();

                var route = new List<string>();
                string startingCity = "";
                string destinationCity;

                while (!departureCities.Contains(startingCity))
                {
                    Console.WriteLine("Enter a city from which you would like to start:");
                    startingCity = Console.ReadLine();
                    route.Add(startingCity);
                }
   
                destinationCity = startingCity;
                    
                do
                {
                    destinationCities.Clear();
                    Console.WriteLine();
                    Console.WriteLine($"From {destinationCity} you can go to the following cities:");
                    foreach (var line in readText)
                    {
                        var cities = line.Split('-');
                        cities[0] = cities[0].Trim();
                        cities[1] = cities[1].Replace("> ", "");
                        if (cities[0].Contains(destinationCity))
                        {
                            destinationCities.Add(cities[1]);
                            Console.WriteLine("- " + cities[1]);                                                                
                        }
                    }
                        
                    while (!destinationCities.Contains(destinationCity))
                    {
                        Console.WriteLine("Enter your next destination city from the list above:");
                        destinationCity = Console.ReadLine();
                    }
                        
                    route.Add(destinationCity);

                } while (destinationCity != startingCity);

                Console.WriteLine();
                Console.WriteLine("Your chosen route is:");
                for(int i = 0; i < route.Count(); i++)
                {
                    if (i == route.Count() -1)
                    {
                        Console.WriteLine(route[i]);
                    }
                    else
                    {
                        Console.Write(route[i] + " -> ");
                    }                        
                }
            }

            Console.ReadKey();
        }
    }
}
