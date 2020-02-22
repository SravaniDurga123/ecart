using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter id");
            string sid = Console.ReadLine();
            Console.WriteLine("menu");
            Console.WriteLine("1.dayscholar");
            Console.WriteLine("2.hosteller");
            int n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine("enter amount");
                double amount = double.Parse(Console.ReadLine());
                DayScholar ds = new DayScholar(name,sid,amount);
                ds.displaydetails();
                Console.WriteLine("amount to pay" + ds.payFee());
            }
            if(n==2)
            {
                Console.WriteLine("enter amount");
                double amount = double.Parse(Console.ReadLine());
              Hosteller hs = new Hosteller(name,sid,amount);
                hs.displaydetails();
                Console.WriteLine("amount to pay" + hs.payFee());
            }
        }
    }
}
