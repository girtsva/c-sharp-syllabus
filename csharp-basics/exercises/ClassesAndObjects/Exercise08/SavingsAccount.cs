using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    class SavingsAccount
    {
        private decimal _annualInterestRate;
        private decimal _accountBalance;
        
        public SavingsAccount(decimal startingBalance)
        {
            _accountBalance = startingBalance;
            _annualInterestRate = 0m;
        }

        public decimal GetAccountBalance()
        {
            return _accountBalance;
        }

        public void SetAccountBalance(decimal newAccountBalance)
        {
            _accountBalance = newAccountBalance;
        }

        public decimal GetInterestRate()
        {
            return _annualInterestRate;
        }

        public void SetInterestRate(decimal newInterestRate)
        {
            _annualInterestRate = newInterestRate;
        }

        public void Withdraw(decimal withdrawalAmount)
        {
            _accountBalance -= withdrawalAmount;
        }

        public void Deposit(decimal depositAmount)
        {
            _accountBalance += depositAmount;
        }

        public decimal AddInterest()
        {
            decimal monthlyInterest = _annualInterestRate / 12 / 100 * _accountBalance;
            _accountBalance += monthlyInterest;
            return monthlyInterest;
        }
    }
}
