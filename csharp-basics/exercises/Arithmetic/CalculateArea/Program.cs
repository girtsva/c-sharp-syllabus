using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user's menu choice.
            var userChoice = GetMenu();
            switch (userChoice)
            {
                case 1:
                    CalculateCircleArea();
                    break;
                case 2:
                    CalculateRectangleArea();
                    break;
                case 3:
                    CalculateTriangleArea();
                    break;
                case 4:
                    Console.WriteLine("Press any key to exit the program!");
                    break;
            }
            Console.ReadKey();
        }

        public static int GetMenu()
        {
            int userChoice;
            
            // Display the menu.
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            // get input from user
            userChoice = int.Parse(Convert.ToString(keyboard.KeyChar));
            Console.WriteLine();
            // validate input
            if (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Invalid choice number! The number must be from 1 to 4.");
                userChoice = 4;
            }
            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            // Get input from user
            Console.WriteLine("What is the circle's radius? ");
            //todo
            decimal radius;
            do
            {
                radius = Convert.ToDecimal(Console.ReadLine());
                if (radius < 0)
                {
                    Console.WriteLine("Radius cannot be less than 0!");
                }
            } while (radius < 0);
            // Display output
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            // Get input from user
            Console.WriteLine("Please provide the length and the width of the rectangle.");
            // Get length
            Console.WriteLine("Enter length? ");
            //todo
            do
            {
                length = Convert.ToDecimal(Console.ReadLine());
                if (length < 0)
                {
                    Console.WriteLine("Length cannot be less than 0!");
                }
            } while (length < 0);
            // Get width
            Console.WriteLine("Enter width? ");
            //todo
            do
            {
                width = Convert.ToDecimal(Console.ReadLine());
                if (width < 0)
                {
                    Console.WriteLine("Width cannot be less than 0!");
                }
            } while (width < 0);
            // Display output
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            // Get input from user
            Console.WriteLine("Please provide the base and the height of the triangle.");
            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
            //todo
            //read key value
            do
            {
                ground = Convert.ToDecimal(Console.ReadLine());
                if (ground < 0)
                {
                    Console.WriteLine("Triangle's base cannot be less than 0!");
                }
            } while (ground < 0);
            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            //todo
            //read key value
            do
            {
                height = Convert.ToDecimal(Console.ReadLine());
                if (height < 0)
                {
                    Console.WriteLine("Triangle's height cannot be less than 0!");
                }
            } while (height < 0);
            // Display the triangle's area.
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
        }
    }
}
