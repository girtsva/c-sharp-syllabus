using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product01 = new Product("Logitech mouse", 70.00, 14);
            Product product02 = new Product("iPhone 5s", 999.99, 3);
            Product product03 = new Product("Epson EB-U05", 440.46, 1);

            product01.PrintProduct();
            product02.PrintProduct();
            product03.PrintProduct();

            product01.Price = 75.99;
            product02.Amount = 5;

            Console.WriteLine();
            product01.PrintProduct();
            product02.PrintProduct();
        }
    }
}
