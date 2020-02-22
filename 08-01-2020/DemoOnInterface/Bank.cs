using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOnInterface
{
    interface loan
    {
        public void getinterest();
    }
    interface Gloan : loan
    {
        public void getgoldloan();

    }
    interface Dmat {
       public  void displaydmat();
}
    abstract public  class Bank
    {
        protected string bname;
        protected string location;
        public Bank(string bname, string location)
        {
            this.bname = bname;
            this.location = location;
        }
         
    }
    public class sbi : Bank, loan,Gloan
    {
        string bmanager;
        public sbi(string bname, string loc, string bmgr) : base(bname, loc)
        {
            this.bmanager = bmgr;
        }
        public void display()
        {
            Console.WriteLine("details");
            Console.WriteLine("bank name " + bname);
            Console.WriteLine("location " + location);
            Console.WriteLine("bank manager name" + bmanager);
        }
        public void getinterest()
        {
            Console.WriteLine("sbi loan interest is 10%");
        }
       public void getgoldloan()
        {
            Console.WriteLine("sbi gives gold loan with 5%");
        }
    }
    public class kothak : Bank,loan,Dmat
    {
        string bmanager;
        public kothak(string bname, string loc, string bmgr) : base(bname, loc)
        {
            this.bmanager = bmgr;
        }
        public void display()
        {
            Console.WriteLine("  ");
            Console.WriteLine("details");
            Console.WriteLine("bank name " + bname);
            Console.WriteLine("location " + location);
            Console.WriteLine("bank manager name" + bmanager);
        }
        public void getinterest()
        {
            Console.WriteLine("kothak loan interest is 12%");
        }
       public void displaydmat()
        {
            Console.WriteLine("kothak can demat accounts");
        }
    }
}
