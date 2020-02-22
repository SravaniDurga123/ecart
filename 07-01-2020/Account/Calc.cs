using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Calc
    {
        static string bname = "sbi";
       private string  Account_no;
        private string Name;
        private string Account_type;
        private char trans_type;
        private double balance;

        public Calc( char trans_type)
        {
            Console.WriteLine("enter account number");
            Account_no = Console.ReadLine();
            Console.WriteLine("enter name");
             Name = Console.ReadLine();
            Console.WriteLine("enter account type");
             Account_type = Console.ReadLine();
            Console.WriteLine("enter balance");
            double balance = double.Parse(Console.ReadLine());
            this.trans_type = trans_type;
            this.balance = balance;
           
        }
        public void credit(double amount)
        {
            balance = balance + amount;
        }
        public void withdraw(Double amount)
        {
            balance = balance - amount;
        }
        public void ShowDetails()
        {
            Console.WriteLine(" bank name: "+bname);
            Console.WriteLine("account number: " +Account_no);
            Console.WriteLine("name: " + Name);
            Console.WriteLine("Account type: " + Account_type);
            Console.WriteLine("transcation type: " + trans_type);
            Console.WriteLine("balance: " + balance);
        }
    }
}
