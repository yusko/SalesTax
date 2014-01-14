using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesTax
{
    class Product
    {
        public string name { get; private set; }
        public float price { get; private set; }
        public bool isTaxable { get; private set; }
        public bool isImported { get; private set; }

        public Product(string name, float price, bool isTaxable, bool isImported)
        {
            this.name = name;
            this.price = price;
            this.isTaxable = isTaxable;
            this.isImported = isImported;
        }


        public float getPrice
        {
            get {return price;}
        }

        public float taxesOnProduct(int quanity)
        {
            return Taxes.calculateSalesTax(quanity * price, isTaxable, isImported);
        }
    }
}
