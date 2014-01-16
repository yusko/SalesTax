using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesTax
{
    class Program
    {
        static void Main(string[] args)
        {
            Order myOrder = new Order();
            myOrder.addOrder(new Product("Book", 12.49, 1, true, true));
            myOrder.addOrder(new Product("Music CD", 14.99, 1, true, true));
            myOrder.addOrder(new Product("Chocolate Bar", 0.85, 1, true, true));

            myOrder.printOrder();
            Console.Read();
        }
    }
}
