using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesTax
{
    class Order
    {
        int quanity;
        Product product;

        public Order(int quanity, Product product)
        {
            this.quanity = quanity;
            this.product = product;
        }

        public float qntyPrice
        {
            get { return product.getPrice * quanity; }
        }
    }
}
