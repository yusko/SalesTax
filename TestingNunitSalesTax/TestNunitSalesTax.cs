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
        [SetUp]
        public void Init()
        {
            pTest = new Product("Coke", 1.50, 1, true, false);
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
    }
}
