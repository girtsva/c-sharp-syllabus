using System;

namespace Persons
{
    public class Student : Person
    {
        protected double GPA { get; set; }

        public Student(string firstName, string lastName, string address, int id, double gpa) : base(firstName, lastName, address, id)
        {
            GPA = gpa;
        }

        public override void Display()
        {
            Console.WriteLine("----------Student Information-----------");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"GPA: {GPA}");
            Console.WriteLine("----------------------------------------");
        }
    }
}
