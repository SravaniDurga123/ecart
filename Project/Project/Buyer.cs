using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   
    class Buyer
    {
        int id;
        string name;
        string email;
        string phn;

        ItemBO ibo = new ItemBO();
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Phn { get => phn; set => phn = value; }

        public Buyer(int bu_id,string bu_name,string bu_email,string bu_pn)
        {
            this.id = bu_id;
            this.name = bu_name;
            this.email = bu_email;
            this.phn = bu_pn;
        }
        public void display()
        {
            Console.WriteLine("buyer name: " + name);
            Console.WriteLine("buyer id:" + id);
            Console.WriteLine("buyer email: " + email);
            Console.WriteLine("buyer phn number: " + phn);
        }
        public void search()
        {
            ibo.searchitem();
        }

        public void displayitem()
        {
            ibo.displayitems();
        }
    }
}
