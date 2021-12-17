using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> list = new List<string> { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            Console.WriteLine("---List---");
            list.ForEach(listItem => Console.WriteLine(listItem));

            HashSet<string> hashset = new HashSet<string> { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            Console.WriteLine("---HashSet---");
            foreach (var item in hashset)
            {
                Console.WriteLine(item);
            }

            Dictionary<string, string> dictionary = new Dictionary<string, string> 
            { 
                { "Audi", "Germany" },
                { "BMW", "Germany" },
                { "Honda", "Japan" }, 
                { "Mercedes", "Germany" }, 
                { "VolksWagen", "Germany" },
                { "Tesla", "USA" }
            };

            Console.WriteLine("---Dictionary---");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"Key: {item.Key, -10} | Value: {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
