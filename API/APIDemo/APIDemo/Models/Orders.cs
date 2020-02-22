using System;
using System.Collections.Generic;

namespace APIDemo.Models
{
    public partial class Orders
    {
        public int Orderid { get; set; }
        public string Customerid { get; set; }
        public DateTime? Orderdate { get; set; }
        public DateTime? Shippeddate { get; set; }
        public decimal? Freight { get; set; }
        public string Shipname { get; set; }
        public string Shipaddress { get; set; }
        public int? Quantity { get; set; }
    }
}
