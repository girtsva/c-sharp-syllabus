using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public abstract class Person
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string Address { get; set; }
        protected int Id { get; set; }

        public Person()
        {
        }

        public Person(string firstName, string lastName, string address, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Id = id;
        }

        public abstract void Display();
    }
}
