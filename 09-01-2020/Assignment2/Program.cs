using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number of tickets");
            int tickets = int.Parse(Console.ReadLine());
            Passenger p = new Passenger(name, age);
            p.ticket_Booking(tickets);
            Console.ReadKey();
        }
    }
}
