using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesTax
{
    class Product
    {
        public enum ProductType
        {
            BOOK,
            MEDICAL,
            FOOD
        }

        public string name { get; set; }
        public decimal price { get; set; }
        public bool localtax { get; set; }
        public bool imported { get; set; }
    }
}
