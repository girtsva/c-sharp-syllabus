using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        private string _name;
        private decimal _balance;

        public BankAccount(string name, double balance)
        {
            _name = name;
            _balance = (decimal)balance;
        }

        public string ShowUserNameAndBalance()
        {
            string specifier = "$#,#0.00;-$#,#0.00";
            return $"{_name}, {_balance.ToString(specifier)}";
        }
    }
}
