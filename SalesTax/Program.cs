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
            // input 1
            myOrder.addOrder(new Product("Book", 12.49, 1, true, false));
            myOrder.addOrder(new Product("Music CD", 14.99, 1, false, false));
            myOrder.addOrder(new Product("Chocolate Bar", 0.85, 1, true, false));

            // input 2
            /*myOrder.addOrder(new Product("imported box of chocolate", 10.00, 1, true, true));
            myOrder.addOrder(new Product("imported bottle of perfume", 47.50, 1, false, true));*/

            // input 3
            /*myOrder.addOrder(new Product("imported bottle of perfume", 27.99, 1, false, true));
            myOrder.addOrder(new Product("bottle of perfume", 18.99, 1, false, false));
            myOrder.addOrder(new Product("packet of headace pills", 9.75, 1, true, false));
            myOrder.addOrder(new Product("box of imported chocolates", 11.25, 1, true, true));*/


            myOrder.printOrder();
            Console.Read();
        }
    }
}
