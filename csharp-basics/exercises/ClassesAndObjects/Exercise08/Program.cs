using System;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("How much money is in the account? ");
            SavingsAccount account001 = new SavingsAccount(Convert.ToDecimal(Console.ReadLine()));
            Console.Write("Enter the annual interest rate: ");
            account001.SetInterestRate(Convert.ToDecimal(Console.ReadLine()));
            Console.Write("How long has the account been opened (in months)? ");
            int months = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            decimal monthlyDeposited;
            decimal monthlyWithdrawn;
            decimal totalDeposited = 0;
            decimal totalWithdrawn = 0;
            decimal totalInterestEarned = 0;

            for (int i = 1; i <= months; i++)
            {
                Console.Write($"Enter amount deposited for month {i}: ");
                monthlyDeposited = Convert.ToDecimal(Console.ReadLine());
                account001.Deposit(monthlyDeposited);
                totalDeposited += monthlyDeposited;

                Console.Write($"Enter amount withdrawn in month {i}: ");
                monthlyWithdrawn = Convert.ToDecimal(Console.ReadLine());
                account001.Withdraw(monthlyWithdrawn);
                totalWithdrawn += monthlyWithdrawn;

                totalInterestEarned += account001.AddInterest();
            }

            string specifier = "$#,#0.00;$(#,#0.00)";

            Console.WriteLine();
            Console.WriteLine($"Total deposited: {totalDeposited.ToString(specifier)}");
            Console.WriteLine($"Total withdrawn: {totalWithdrawn.ToString(specifier)}");
            Console.WriteLine($"Interest earned: {totalInterestEarned.ToString(specifier)}");
            Console.WriteLine($"Ending balance: {account001.GetAccountBalance().ToString(specifier)}");
        }
    }
}
