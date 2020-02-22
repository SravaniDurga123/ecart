using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
   abstract class Player
    {
        protected string name;
        protected string teamname;
        protected int noofmatches;
        
        public Player(string name,string teamname,int noofmatches)
        {
            this.name = name;
            this.teamname = teamname;
            this.noofmatches = noofmatches;
        }
        public abstract void Displayplayerdetails();
    }
    class CricketPlayer: Player
    {
        private int total_run_scored;
        private int no_of_wickets;

        public CricketPlayer(int total_run_scored, int no_of_wickets,string name,string tname,int no_of_matches):base(name,tname, no_of_matches)
        {
            this.total_run_scored = total_run_scored;
            this.no_of_wickets = no_of_wickets;
        }
        public override void Displayplayerdetails()
        {
            Console.WriteLine("detais of players"); ;
            Console.WriteLine("player name:" + name);
            Console.WriteLine("team name: " + teamname);
            Console.WriteLine("no of matches: " + noofmatches);
            Console.WriteLine("total run scored: " + total_run_scored);
            Console.WriteLine("no of wickets: " + no_of_wickets);
        }
    }
    class HockeyPlayer : Player
    {
        private string position;
        private int no_of_goals;

        public HockeyPlayer(string position, int no_of_goals,string name,string tname,int no_of_matches):base(name,tname,no_of_matches)
        {
            this.position = position;
            this.no_of_goals = no_of_goals;
        }
        public override void Displayplayerdetails()
        {
            Console.WriteLine("detais of players"); ;
            Console.WriteLine("player name:" + name);
            Console.WriteLine("team name: " + teamname);
            Console.WriteLine("no of matches: " + noofmatches);
            Console.WriteLine("total run scored: " + position);
            Console.WriteLine("no of goals: " + no_of_goals);
        }
    }
}
