using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("menu");
            Console.WriteLine("1.Cricket player details");
            Console.WriteLine("2.Hockey Player details");
            Console.WriteLine("3.exit");
            Console.WriteLine("enter choice");
            int ch = int.Parse(Console.ReadLine());
            if(ch==1)
            {
                Console.WriteLine("enter cricket player name");
                String name = Console.ReadLine();
                Console.WriteLine("enter team name");
                String tname = Console.ReadLine();
                Console.WriteLine("enter no of matches");
                int no_of_matches = int.Parse(Console.ReadLine());
                Console.WriteLine("enter total run scored");
                int total_run_scored = int.Parse(Console.ReadLine());
                Console.WriteLine("enter no of wickets");
                    int no_of_wickets = int.Parse(Console.ReadLine());
                CricketPlayer c = new CricketPlayer(total_run_scored, no_of_wickets, name, tname,no_of_matches);
                c.Displayplayerdetails();
               
            }
           else if(ch==2)
            {
                Console.WriteLine("enter hockey player name");
                String name = Console.ReadLine();
                Console.WriteLine("enter team name");
                String tname = Console.ReadLine();
                Console.WriteLine("enter no of matches");
                int no_of_matches = int.Parse(Console.ReadLine());
                Console.WriteLine("enter position");
                string position = Console.ReadLine();
                Console.WriteLine("enter no of goals");
                int goals = int.Parse(Console.ReadLine());
                HockeyPlayer h = new HockeyPlayer(position,goals,name,tname,no_of_matches);
                h.Displayplayerdetails();
            }
            else
            {
                Environment.Exit(0);
                
            }
            Console.ReadKey();
        }
    }
}
