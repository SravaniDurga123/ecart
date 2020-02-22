using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
   abstract class Student
    {
       protected string sid;
        protected string name;
      protected  double examfee=780;
        
      public  Student(string name,string sid)
        {
            this.name = name;
            this.sid = sid;
        }
        public void displaydetails()
        {
            Console.WriteLine("name= " + name);
            Console.WriteLine("student id=" + sid);
           
        }
        public abstract double payFee();
       
    }
    class DayScholar : Student
    {
        double trans_fee;

      public  DayScholar(string name,string sid,double amount):base(name,sid)
        {
            trans_fee = amount;  
        }
        public override double payFee()
        {
            return (trans_fee + examfee);
        }
    }
    class Hosteller : Student
    {
        double hostelfee;
        public Hosteller(string name, string sid,double amount):base(name,sid)
        {
            hostelfee = amount;
        }
        public override double payFee()
        {
            return (hostelfee + examfee);
        }
    }
}
