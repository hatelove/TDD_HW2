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
            return (bookInfo.Order["1"] + bookInfo.Order["2"] + bookInfo.Order["3"] + 
                    bookInfo.Order["4"] + bookInfo.Order["5"]) * bookInfo.price;
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

        }
    }
}
