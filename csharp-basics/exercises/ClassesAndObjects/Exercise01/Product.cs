using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class Product
    {
        private string _name;
        public double Price { get; set; }
        public int Amount { get; set; }

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            Price = priceAtStart;
            Amount = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, price {Price} EUR, amount {Amount} units");
        }
    }
}
