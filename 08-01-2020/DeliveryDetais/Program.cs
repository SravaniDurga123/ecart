using System;

namespace DeliveryDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("menu");
            Console.WriteLine("1.player detais of the delivery");
            Console.WriteLine("2.Run details of the delivery");
            Console.WriteLine("enter choices");
            int n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine("enter bowler name");
                string b_name = Console.ReadLine();
                Console.WriteLine("enter bastman name");
                string bt_name = Console.ReadLine();
                Delivery d = new Delivery();
                d.DisplayDeliveryDetails(b_name, bt_name);
            }
            if (n == 2)
            {
                Console.WriteLine("enter runs");
                int runs = int.Parse(Console.ReadLine());
                
                Delivery d = new Delivery();
                d.DisplayDeliveryDetails(runs);
            }
        }
    }
}
