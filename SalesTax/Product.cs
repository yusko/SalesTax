using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesTax
{
    class Product
    {
        public string name { get; private set; }
        public ProductType type { get; private set; }
        public ProductRegion region { get; private set; }
        public decimal price { get; private set; }

        public Product(string name, ProductType type, ProductRegion region, decimal price)
        {
            this.name = name;
            this.type = type;
            this.region = region;
            this.price = price;
        }

        public ProductType getType()
        {
            return type;
        }

        public decimal getPrice()
        {
            return price;
        }

        public Boolean isImported()
        {
            return region == ProductRegion.IMPORTED;
        }

        public Boolean isExempt()
        {
            if ((type == ProductType.FOOD) || (type == ProductType.BOOK) || (type == ProductType.MEDICAL))
                return true;
            else
                return false;
        }
    }
}
