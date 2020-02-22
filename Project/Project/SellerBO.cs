using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SellerBO
    {
        string catname;
        int cid;
        string sub_name;
       int sub_id;
        string sub_det;
        string item_name;
        int item_id;
        string item_det;
        double price;
        double gst;

        public string Catname { get => catname; set => catname = value; }
        public int Cid { get => cid; set => cid = value; }
        public string Sub_name { get => sub_name; set => sub_name = value; }
        public int Sub_id { get => sub_id; set => sub_id = value; }
        public string Sub_det { get => sub_det; set => sub_det = value; }
        public string Item_name { get => item_name; set => item_name = value; }
        public int Item_id { get => item_id; set => item_id = value; }
        public string Item_det { get => item_det; set => item_det = value; }
        public double Price { get => price; set => price = value; }
        public double Gst { get => gst; set => gst = value; }

        public void additems()
        {
            Console.WriteLine("How many items Do you want Add");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Item No. : ");
                int itemno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter category Id:");
                int cid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Category Name : ");
                string cname = Console.ReadLine();
                Console.WriteLine("Enter Category Description : ");
                string cdesc = Console.ReadLine();
                Console.WriteLine("Enter SubCategory Id:");
                int scid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter SubCategory Name : ");
                string scname = Console.ReadLine();
                Console.WriteLine("Enter SubCategory Description : ");
                string scdesc = Console.ReadLine();
                Console.WriteLine("Enter name of item: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Quantity of item:");
                int noi = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Price of Item:");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("enter Gst");
                int GST = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Description for item");
                string desc = Console.ReadLine();
                ItemBO ibo = new ItemBO();
                ibo.additems(itemno, cid, scid, name, cname, scname, noi, price,GST, desc, cdesc, scdesc);

            }
        }
    }
}

