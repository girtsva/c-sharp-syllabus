using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class Product
    {
        public string Name { get; private set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            Name = name;
            Price = priceAtStart;
            Amount = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{Name}, price {Price} EUR, amount {Amount} units");
        }
    }
}
