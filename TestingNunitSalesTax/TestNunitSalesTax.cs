using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace SalesTax
{
    [TestFixture]
    class TestNunitSalesTax
    {
        Product pTest;
        Order myOrder; 

        [SetUp]
        public void Init()
        {
            pTest = new Product("Coke", 1.50, 1, true, false);
            myOrder = new Order();
        }
        [Test]
        public void isProductEqual()
        {
            Assert.AreEqual("Coke", pTest.name);
        }
        [Test]
        public void ProductNotEqual()
        {
            Assert.AreNotEqual("Sode", pTest.name);
        }

        [Test]
        /* test for non imported products */
        public void testForNonImportedProducts()
        {
            myOrder.addOrder(new Product("book", 9.99, 1, false, false));
            myOrder.addOrder(new Product("CD", 12.99, 1, false, false));
            myOrder.addOrder(new Product("Bagel", 3.99, 1, false, false));
            Assert.NotNull(myOrder, "There are prodcuts in your order the order is not empty");
            Assert.AreEqual(3, 3, "the number or product in the order is equal");
            Assert.AreEqual(0.05, Taxes.calculateSalesTax(0.05, false, false), "Total sales tax for non import prodcuts");
        }
        [Test]
        /* test for imported products */
        public void testForImportedProducts()
        {
            myOrder.addOrder(new Product("book", 19.99, 1, false, true));
            myOrder.addOrder(new Product("CD", 7.99, 1, false, true));
            myOrder.addOrder(new Product("Bagel", 2.99, 1, false, true));
            Assert.NotNull(myOrder, "There are prodcuts in your order the order is not empty");
            Assert.AreEqual(3, 3, "the number or product in the order is equal");
            Assert.AreEqual(1.50, Taxes.calculateSalesTax(9.99, false, true), "Total sales tax for non import prodcuts");
        }
    }
}
