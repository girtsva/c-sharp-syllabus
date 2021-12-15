using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount benben = new BankAccount("Benson", 17.25);
            BankAccount benbenMinus = new BankAccount("Benson Broke", -17.5);

            Console.WriteLine(benben.ShowUserNameAndBalance());
            Console.WriteLine(benbenMinus.ShowUserNameAndBalance());

            Console.ReadKey();
        }
    }
}
