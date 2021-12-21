using System;

namespace Persons
{
    class Employee : Person
    {
        protected string JobTitle { get; set; }

        public Employee(string firstName, string lastName, string address, int id, string jobTitle) : base(firstName, lastName, address, id)
        {
            JobTitle = jobTitle;
        }

        public override void Display()
        {
            Console.WriteLine("----------Employee Information----------");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Job Title: {JobTitle}");
            Console.WriteLine("----------------------------------------");
        }
    }
}
