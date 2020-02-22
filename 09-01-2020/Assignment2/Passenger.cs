using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class TicketsException : Exception
    {
        public TicketsException(string s) : base(s)
        {

        }
    }
    class Passenger
    {
        string name;
        int age;

        public Passenger(string name,int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("name" + name);
            Console.WriteLine("age" + age);
        }
        public void ticket_Booking(int no_of_tickets)
        {
            
            
            try
            {
                if (no_of_tickets > 2) throw new TicketsException("cannot book more than 2");

                else
                    Console.WriteLine("ticket booked successfully");
            }
            catch (TicketsException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
