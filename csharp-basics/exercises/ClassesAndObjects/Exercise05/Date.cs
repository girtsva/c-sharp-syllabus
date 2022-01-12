using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    public class Date
    {
        public int Day { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public string DisplayDate()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
