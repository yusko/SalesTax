using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesTax
{
    class Taxes
    {
        static readonly float LOCAL = 0.10F;
        //static readonly float DUTY = 0.05F;

        public static double calculateSalesTax(double amount, bool taxable, bool import)
        {
            amount = LOCAL * amount;
            amount = Math.Ceiling(amount / 0.005) * 0.005;
            Console.WriteLine("amount: {0}", amount);
            return amount;
        }
    }
}
