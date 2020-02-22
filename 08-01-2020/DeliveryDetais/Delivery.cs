using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryDetails
{
    class Delivery
    {
        public void DisplayDeliveryDetails(string bowler,string batsman)
        {
            Console.WriteLine("bowler name" + bowler);
            Console.WriteLine("batsman name" + batsman);
        }
        public void DisplayDeliveryDetails(long runs)
        {
            
            if(runs==6 )
            {
                Console.WriteLine("It is a six and runs " + runs);
            }
            else if(runs == 4)
            {
                Console.WriteLine(" It is a four and runs " + runs);
            }
            else
            {
                Console.WriteLine("Number of runs " + runs);
            }
        }
    }
}
