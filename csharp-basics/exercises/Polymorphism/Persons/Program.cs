using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * - Create an instant of class Student and an instant of class Employee with proper values for the attributes.
             * - Display the content of each class using Display() method.
             */

            Student john = new Student("John", "Doe", "457 Mullholland Drive, NY", 101, 4.3);
            Employee maria = new Employee("Maria", "Banks", "324 Sea Road, CA", 50, "Accountant");

            john.Display();
            maria.Display();
        }
    }
}