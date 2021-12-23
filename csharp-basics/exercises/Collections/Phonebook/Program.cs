using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phonebook = new PhoneDirectory();

            phonebook.PutNumber("Harry", "0037125875493");
            phonebook.PutNumber("Fred", "0004815262485");
            phonebook.PutNumber("John", "0000132561437");
            phonebook.PutNumber("Harry", "0000185451464");

            Console.WriteLine(phonebook.GetNumber("Harry"));

            phonebook.ShowWholePhonebook();

            Console.ReadKey();
        }
    }
}
