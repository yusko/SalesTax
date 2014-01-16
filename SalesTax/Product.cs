using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesTax
{
    class Product
    {
        public string name { get; private set; }
        public double price { get; private set; }
        public int quanity { get; private set; }
        public bool isTaxable { get; private set; }
        public bool isImported { get; private set; }

        public Product(string name, double price, int quanity, bool isTaxable, bool isImported)
        {
            this.name = name;
            this.price = price;
            this.quanity = quanity;
            this.isTaxable = isTaxable;
            this.isImported = isImported;
        }


        public double taxesOnProduct(int quanity)
        {
            double amount = quanity * price;
            Console.WriteLine("amount: {0} ", amount);
            return Taxes.calculateSalesTax(amount, isTaxable, isImported);
        }
    }
}
