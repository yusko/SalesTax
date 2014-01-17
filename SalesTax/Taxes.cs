using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesTax
{
    /*
     * Taxes class which will handle all tax related methods.
     */

    public class Taxes
    {
        /*
         * static read only value for local tax and import tax
         */

        static readonly double LOCAL = 0.10;
        static readonly double DUTY = 0.05;

        /*
         * calculates the tax based on whether it is exempted and whether it is imported or not.
         * rounding rules is np/100 rounded up tot he nearest 0.05 amount of the sales tax.
         * 
         * @return double
         */
        public static double calculateSalesTax(double amount, bool exempted, bool import)
        {
            // imported product
            if (import == true)
            {
                // product is exempt from tax
                if (exempted == true)
                {
                    amount = Math.Ceiling(20 * (amount * DUTY)) / 20;
                }
                // product is not exempt from tax
                else
                {
                    amount = Math.Ceiling(20 * (amount * (LOCAL + DUTY))) / 20;
                }
            }
            // not an imported product
            else
            {
                // product is exempt
                if (exempted == true)
                {
                    amount = Math.Ceiling(20 * (amount * 0)) / 20;
                }
                // product is not exempt
                else
                {
                    amount = Math.Ceiling(20 * (amount * LOCAL)) / 20;
                }
            }
            return amount;
        }
    }
}
