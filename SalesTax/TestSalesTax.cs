﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace SalesTax
{
    [TestFixture]
    public class TestSalesTax
    {
        Product pTest;

        [SetUp]
        public void init()
        {
            //All initalizations
            pTest = new Product("Soda", 12.99, 1, false, false);
        }
        [Test]
        public void isProductEqual()
        {

        }
    }
}