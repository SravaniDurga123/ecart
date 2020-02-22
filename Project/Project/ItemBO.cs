 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ItemBO
    {
        static List<Item> litem = new List<Item>();
        static List<Category> lcategory = new List<Category>();
       
        public void additems(int itemno,int cid,int scid,string itemname,string cname,string scname,int noi,double price,double GST,string itemdesc,string cdesc,string scdesc)
        {
            SubCategory sub = new SubCategory(cid, scid, cname,cdesc,scname,scdesc);
            litem.Add(new Item(cid, itemno,itemname, itemdesc,noi, price, GST, sub));

        }
        public void searchitem()
        {
            Console.WriteLine("enter item name to search");
            string it_name = Console.ReadLine();
            int f = 0;
            Console.WriteLine(" itemId \t itemName \t category ID \t Category Name \t subcategory Id \t subcategory name \t item desc \t price \t GST");
            foreach (Item i in litem)
            {
                if (it_name.Equals(i.Item_name))
                {
                    f = 1;
                    Console.WriteLine(i.Item_id + "\t" +i.Item_name+"\t"+ i.Cid + "\t"+ i.Sub.Cname + "\t"+ i.Sub.Sub_id + "\t"  + i.Sub.Sub_name + "\t" + i.Item_det + "\t" + + i.Price + "\t" + i.Gst);
                }
            }
            if (f == 0)
                Console.WriteLine("item not found");
        }
        public void displayitems()
        {
            Console.WriteLine(" itemId \t itemName \t category ID \t Category Name \t subcategory Id \t subcategory name \t item desc \t price \t GST");

            foreach (Item i in litem)
            {
                Console.WriteLine(i.Item_id + "\t" + i.Item_name + "\t" + i.Cid + "\t"  + i.Sub.Cname + "\t"  + i.Sub.Sub_id + "\t" + i.Sub.Sub_name + "\t" + i.Item_det + "\t" +  i.Price + "\t" + i.Gst);

            }
        }
    }
}


