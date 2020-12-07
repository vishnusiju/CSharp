using System;
using System.Collections.Generic;
using System.Text;

namespace oopz
{
    public class Order
    {
        public string OrderNo {  get; set; }
        public string OredrValue { get; set; }
        public string OrderCoundry { get; set; }


        public string CreateOrder()
        {
            return "Order Created";
        }
        public bool validateOrderValue()
        {
            return true;
        }
        public bool validateOrderCountry()
        {
            return true;
        }
    }
}
