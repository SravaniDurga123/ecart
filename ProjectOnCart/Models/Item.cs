using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOnCart.Models
{
    public class Item
    {
        public int item_no { get; set; }
         public int no_of_items { get; set; }
        public double price { get; set; }
        public int subcategory_id { get; set; }
        public string seller_name { get; set; }

    }
}
