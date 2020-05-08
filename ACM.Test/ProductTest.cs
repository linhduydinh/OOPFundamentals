using ACM.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Test
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateProductNameAndCurrentPriceIsValid()
        {
            var product = new Product();
            product.ProductName = "Iphone";
            product.CurrentPrice = 15;

            var expect = true;

            Assert.AreEqual(expect, product.Validate());
        }

        [TestMethod]
        public void ValidateProductNameIsNotValid()
        {
            var product = new Product();
            product.ProductName = null;

            var expect = false;

            Assert.AreEqual(expect, product.Validate());
        }

        [TestMethod]
        public void ValidateCurrentPriceIsNotValid()
        {
            var product = new Product();
            product.CurrentPrice = null;

            var expect = false;

            Assert.AreEqual(expect, product.Validate());
        }
    }
}
