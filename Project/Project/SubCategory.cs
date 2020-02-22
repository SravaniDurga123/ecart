using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SubCategory :Category
    {
        int cid;
        int sub_id;
        string sub_name;
        string sub_det;
        string cname;
        string cdesc;
      public  SubCategory(int cid,int  scid,string cname,string cdesc,string scname,string scdesc)
        {
            this.Cid = cid;
            this.Sub_id = scid;
            this.Cname = cname;
            this.Cdesc = cdesc;
            this.Sub_name = scname;
            this.Sub_det = scdesc;
           
        }

       
        public int Sub_id { get => sub_id; set => sub_id = value; }
        public string Sub_name { get => sub_name; set => sub_name = value; }
        public string Sub_det { get => sub_det; set => sub_det = value; }
        public string Cname { get => cname; set => cname = value; }
        public string Cdesc { get => cdesc; set => cdesc = value; }
    }
}
