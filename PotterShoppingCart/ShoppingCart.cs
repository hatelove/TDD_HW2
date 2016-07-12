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
            int numOfVolume = 0;
            foreach (var kvp in bookInfo.Order)
            {
                if(kvp.Value == 0)
                {
                    continue;
                }

                numOfVolume++;

            }

            int orders = bookInfo.Order["1"] + bookInfo.Order["2"] + bookInfo.Order["3"] + 
                            bookInfo.Order["4"] + bookInfo.Order["5"];

            return numOfVolume * bookInfo.price * bookInfo.discount[numOfVolume] + 
                    (orders - numOfVolume) * bookInfo.price * bookInfo.discount[(orders - numOfVolume)];
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
                { 0, 1},{ 1, 1}, {2,0.95}, { 3, 0.9}, { 4,0.8}, { 5,0.75}
            };
        }
    }
}
