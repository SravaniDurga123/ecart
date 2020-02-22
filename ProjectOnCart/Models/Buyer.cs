using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOnCart.Models
{
    public class Buyer
    {
        public int  buyer_id { get; set; }
        public string buyer_name { get; set; }
        public string buyer_email { get; set; }
        public string buyer_phnno { get; set; }
        public string buyer_pswd { get; set; }
        public string conformpswd { get; set; }

    }
}
