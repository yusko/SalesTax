using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SalesTax
{
    class Order
    {
        /*  a list to store the product */
        private List<Product> orderList;

        /* 
         *  instantiates a new order to which product can be added
         */
        public Order()
        {
            orderList = new List<Product>();
        }

        /*  
         *  adds the product
         *  param product - the product to be added to the order
         */
        public void addOrder(Product product)
        {
            orderList.Add(product);
        }

        /*  
         *  retrieves the item from order
         *  @return a list containing product
         */
        public void printOrder()
        {
            double totalTax = 0;
            double netTotal = 0;
            foreach(var product in orderList)
            {
                double tax = product.taxesOnProduct(product.quanity);
                Console.WriteLine(product.quanity + " " + product.name + " : " + product.price);
                totalTax += tax;
               // netTotal += product.price + tax;
            }
            Console.WriteLine("Total Tax : {0}", Math.Ceiling(totalTax / 0.005) * 0.005);
            Console.WriteLine("Total : " + (int)netTotal + (int)Math.Round((netTotal* 0.05)/5) * 5);
        }

    }
}
