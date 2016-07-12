using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void CalculatePriceTest_第一集買一本_價格為_100()
        {
            // arrange
            Dictionary<string, int> orders = new Dictionary<string, int>
            {
                { "1", 1}, { "2",0}, { "3", 0}, { "4",0}, {"5",0 }
            };

            ShoppingCart shoppingCart = new ShoppingCart();

            double expected = 100;

            // act
            double actual = shoppingCart.CalculatePrice(orders);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}