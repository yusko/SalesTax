using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * The product which will store the order items and calculate the tax on product based on quanity.
 * 
 * 
 */
namespace SalesTax
{
    class Product
    {
        /** name of product */
        public string name { get; private set; }
        /** price of the product */
        public double price { get; private set; }
        /** number of quanity */
        public int quanity { get; private set; }
        /** check if the product is exepmted */
        public bool isTaxable { get; private set; }
        /** check if the product is imported */
        public bool isImported { get; private set; }

        /**
         * constructor to initialize the product attributes.
         * 
         * @param name - the name of the product
         * @param price - price of the product
         * @param quanity - the number of quanity of the product
         * @param isTaxable - boolean value to determine product is exempted or not
         * @param isImported - boolean value to determine product is imported or not
         * 
         */
        public Product(string name, double price, int quanity, bool isTaxable, bool isImported)
        {
            this.name = name;
            this.price = price;
            this.quanity = quanity;
            this.isTaxable = isTaxable;
            this.isImported = isImported;
        }

        /**
         * gets the tax on product based on number of quanity
         * 
         * @return double;
         * 
         */
        public double taxesOnProduct(int quanity)
        {
            double amount = quanity * price;
            return Taxes.calculateSalesTax(amount, isTaxable, isImported);
        }
    }
}
