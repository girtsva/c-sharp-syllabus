using System;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new EmployeePay("Employee 1", 7.50, 35);
            var employee2 = new EmployeePay("Employee 2", 8.20, 47);
            var employee3 = new EmployeePay("Employee 3", 10.00, 73);

            Console.WriteLine(employee1.PayoutMessage());
            Console.WriteLine(employee2.PayoutMessage());
            Console.WriteLine(employee3.PayoutMessage());
        }
    }
}
