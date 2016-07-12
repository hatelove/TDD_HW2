using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    public class ShoppingCart
    {
        BookInfo bookInfo = new BookInfo();

        public double CalculatePrice(BookInfo bookInfo)
        {
            int amount = 0;
            foreach (var kvp in bookInfo.Order)
            {
                if(kvp.Value == 0)
                {
                    continue;
                }

                amount++;

            }

            return (bookInfo.Order["1"] + bookInfo.Order["2"] + bookInfo.Order["3"] + 
                    bookInfo.Order["4"] + bookInfo.Order["5"]) * bookInfo.price * bookInfo.discount[amount];
        }

        public class BookInfo
        {
            public double price
            {
                get
                {
                    return 100;
                }
            }

            public Dictionary<string, int> Order = new Dictionary<string, int>
            {
                { "1", 0}, { "2",0}, { "3", 0}, { "4",0}, {"5",0 }
            };


            public Dictionary<int, double> discount = new Dictionary<int, double>
            {
                { 1, 1}, {2,0.95}, { 3, 0.9}, { 4,0.8}, { 5,0.75}
            };
        }
    }
}
