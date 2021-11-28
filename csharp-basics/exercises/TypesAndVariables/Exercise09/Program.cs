using System;

namespace Exercise09
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a C# program to takes the user for a distance (in meters) and the time was taken
             * (as three numbers: hours, minutes, seconds), and display the speed, in meters per second,
             * kilometers per hour and miles per hour (hint: 1 mile = 1609 meters).
             */

            Console.WriteLine("In order to calculate your speed, you will be asked to enter distance and time.");
            Console.WriteLine("\nYour Data");
            Console.Write("Input distance in meters: ");
            decimal userMeters = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Input hours: ");
            int userHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input minutes: ");
            int userMinutes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input seconds: ");
            int userSeconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int totalSeconds = userHours * 3600 + userMinutes * 60 + userSeconds;
            decimal totalHours = Convert.ToDecimal(totalSeconds) / 3600;

            decimal totalKm = userMeters / 1000;
            decimal totalMiles = userMeters / 1609;

            decimal speedInMetersPerSecond = Math.Round(userMeters / totalSeconds, 8);
            decimal speedInKmPerHour = Math.Round(totalKm / totalHours, 8);
            decimal speedInMilesPerHour = Math.Round(totalMiles / totalHours, 8);

            Console.WriteLine($"Your speed in meters/second is {speedInMetersPerSecond}");
            Console.WriteLine($"Your speed in km/h is {speedInKmPerHour}");
            Console.WriteLine($"Your speed in miles/h is {speedInMilesPerHour}");
        }
    }
}
