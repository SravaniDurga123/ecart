using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Seller
    {
        int id;
        string name;
         string phno;
        private string GSTIN;
        private string email;
        private string cpname;

        public Seller(int id,string name,string email,string phno,string GSTIN,string cpname)
        {
            this.Id = id;
            this.Name = name;
            this.Phno = phno;
            this.GSTIN1 = GSTIN;
            this.Cpname = cpname;
            this.Email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phno { get => phno; set => phno = value; }
        public string GSTIN1 { get => GSTIN; set => GSTIN = value; }
        public string Email { get => email; set => email = value; }
        public string Cpname { get => cpname; set => cpname = value; }

        public void details()
        {
            Console.WriteLine("---My Profile--");
            Console.WriteLine("Seller id: " + Id);
            Console.WriteLine("seller name: " + Name);
            Console.WriteLine("seller email: " + Email);
            Console.WriteLine("seller phone number: " + Phno);
            Console.WriteLine("GSTIN number: " + GSTIN1);
            Console.WriteLine("company name: " + Cpname);
        }
    }
    
    
        
}
