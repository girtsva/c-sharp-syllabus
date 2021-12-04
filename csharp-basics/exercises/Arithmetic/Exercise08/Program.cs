using System;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            static string TotalPay(double basePay, decimal hoursWorked)
            {
                decimal basePayDec = Convert.ToDecimal(basePay);
                decimal overtimePay = basePayDec * 1.5m;
                decimal workHourLimit = 40m;
                decimal overtime = hoursWorked - workHourLimit;
                decimal minimumWage = 8.00m;
                decimal maxHoursWorked = 60m;

                if (basePayDec < minimumWage)
                {
                    return $" base pay must not be less than the minimum wage (${minimumWage} an hour).";
                }
                else if (hoursWorked > maxHoursWorked)
                {
                    return $" can not work more than {maxHoursWorked} hours in a week.";
                }
                else
                {
                    decimal totalPay = workHourLimit * basePayDec + overtime * overtimePay;
                    string totalPayString = totalPay.ToString("N2");
                    return $" total pay is ${totalPayString}.";
                }
            }         

            Console.WriteLine("Employee 1" + TotalPay(7.50, 35));
            Console.WriteLine("Employee 2" + TotalPay(8.20, 47));
            Console.WriteLine("Employee 3" + TotalPay(10.00, 73));
        }
    }
}
