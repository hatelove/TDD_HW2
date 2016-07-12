using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    public class ShoppingCart
    {
        Dictionary<string, int> shoopingCar = new Dictionary<string, int>
            {
                { "1", 0}, { "2",0}, { "3", 0}, { "4",0}, {"5",0 }
            };


        public double CalculatePrice(Dictionary<string, int> shoopingCar)
        {
            throw new NotImplementedException();
        }
    }
}
