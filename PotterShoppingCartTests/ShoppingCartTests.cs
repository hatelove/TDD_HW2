using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ShoppingCart.ShoppingCart;

namespace ShoppingCart.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void CalculatePriceTest_第一集買一本_價格為_100()
        {
            // arrange
            BookInfo bookInfo = new BookInfo();

            bookInfo.Order = new Dictionary<string, int>
            {
                { "1", 1}, { "2",0}, { "3", 0}, { "4",0}, {"5",0 }
            };

            ShoppingCart shoppingCart = new ShoppingCart();

            double expected = 100;

            // act
            double actual = shoppingCart.CalculatePrice(bookInfo);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_第一集買一本_第二集買一本_價格為_190()
        {
            // arrange
            BookInfo bookInfo = new BookInfo();

            bookInfo.Order = new Dictionary<string, int>
            {
                { "1", 1}, { "2",1}, { "3", 0}, { "4",0}, {"5",0 }
            };

            ShoppingCart shoppingCart = new ShoppingCart();

            double expected = 190;

            // act
            double actual = shoppingCart.CalculatePrice(bookInfo);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_第一二三集各買一本_價格為_270()
        {
            // arrange
            BookInfo bookInfo = new BookInfo();

            bookInfo.Order = new Dictionary<string, int>
            {
                { "1", 1}, { "2",1}, { "3", 1}, { "4",0}, {"5",0 }
            };

            ShoppingCart shoppingCart = new ShoppingCart();

            double expected = 270;

            // act
            double actual = shoppingCart.CalculatePrice(bookInfo);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_第一二三四集各買一本_價格為_320()
        {
            // arrange
            BookInfo bookInfo = new BookInfo();

            bookInfo.Order = new Dictionary<string, int>
            {
                { "1", 1}, { "2",1}, { "3", 1}, { "4",1}, {"5",0 }
            };

            ShoppingCart shoppingCart = new ShoppingCart();

            double expected = 320;

            // act
            double actual = shoppingCart.CalculatePrice(bookInfo);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_第一二三四五集買一本_價格為_375()
        {
            // arrange
            BookInfo bookInfo = new BookInfo();

            bookInfo.Order = new Dictionary<string, int>
            {
                { "1", 1}, { "2",1}, { "3", 1}, { "4",1}, {"5",1}
            };

            ShoppingCart shoppingCart = new ShoppingCart();

            double expected = 375;

            // act
            double actual = shoppingCart.CalculatePrice(bookInfo);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_第一二集各買一本_第三集買兩本_價格為_370()
        {
            // arrange
            BookInfo bookInfo = new BookInfo();

            bookInfo.Order = new Dictionary<string, int>
            {
                { "1", 1}, { "2",1}, { "3", 2}, { "4",0}, {"5",0}
            };

            ShoppingCart shoppingCart = new ShoppingCart();

            double expected = 370;

            // act
            double actual = shoppingCart.CalculatePrice(bookInfo);

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}