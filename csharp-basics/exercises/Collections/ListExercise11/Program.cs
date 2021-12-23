using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> foods = new List<string>();

            foods.Add("Banana");
            foods.Add("French fries");
            foods.Add("Omelette");
            foods.Add("Meatballs");
            foods.Add("Cherries");
            foods.Add("Broccoli");
            foods.Add("Oatmeal");
            foods.Add("Cheeseburger");
            foods.Add("Beans");
            foods.Add("Ice cream");

            foods.Insert(4, "Ketchup");

            foods[foods.Count - 1] = "Cheese cake";

            foods.Sort();

            Console.WriteLine(foods.Contains("Foobar"));

            foreach (var food in foods)
            {
                Console.WriteLine(food);
            }

            Console.ReadKey();            
        }
    }
}
