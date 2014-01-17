using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SalesTax
{
    /**
     * the order holds the product purchased and prints the recipt.
     * 
     */ 

    public class Order
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
            /** initializes the values for total tax and net total */
            double totalTax = 0;
            double netTotal = 0;
            foreach(var product in orderList)
            {
                // gets the tax based on product quanity 
                double tax = product.taxesOnProduct(product.quanity);
                Console.WriteLine("{0} {1} : {2:N2}", product.quanity, product.name, product.price + tax);
                // tallys the total tax amount
                totalTax += tax;
                // tallys the total cost
                netTotal = netTotal + (product.price * product.quanity);
            }
            // sums the total net amount and tax amount
            netTotal = netTotal + totalTax;
            Console.WriteLine("Sales Taxes: {0:N2}", totalTax);
            Console.WriteLine("Total: {0:N2}", netTotal);
        }
        
        /*
         * retrieve the number of prodcut in our order
         * @return prodcut count
         *
         */ 

        public int getOrderSize()
        {
            return orderList.Count();
        }
    }
}
