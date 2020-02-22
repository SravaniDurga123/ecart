using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Item 
    {
        int cid;
        int item_id;
        string item_name;
        string item_det;
        int noi;
        double gst;
        double price;
       
        SubCategory sub;
        public int Cid { get => cid; set => cid = value; }
        public int Item_id { get => item_id; set => item_id = value; }
        public string Item_name { get => item_name; set => item_name = value; }
        public double Gst { get => gst; set => gst = value; }
        public double Price { get => price; set => price = value; }
        public string Item_det { get => item_det; set => item_det = value; }
        public int Noi { get => noi; set => noi = value; }
        internal SubCategory Sub { get => sub; set => sub = value; }

        public Item(int cid,int  itemno,string itemname,string itemdesc,int noi,double price,double GST,  SubCategory sub)
        {
            this.cid = cid;
            this.item_id = itemno;
            this.item_name = itemname;
            this.item_det = itemdesc;
            this.Noi = noi;
            this.price = price;
            this.gst = GST;
            this.sub = sub;
        }
    }
}
