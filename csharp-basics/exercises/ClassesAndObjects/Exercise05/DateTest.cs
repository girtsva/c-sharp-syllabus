using System;

namespace Exercise05
{
    class DateTest
    {
        static void Main(string[] args)
        {
            Date newDate = new Date(14, 12, 2021);
            
            Console.WriteLine(newDate.DisplayDate());
        }
    }
}
