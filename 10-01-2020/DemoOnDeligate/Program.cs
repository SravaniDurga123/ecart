using System;

namespace DemoOnDeligate
{
    public delegate void deligatepointer();
    public delegate double circledeligatepointer(double x);
    class Program
    {
       
        static void Main(string[] args)
        {
            Program p = new Program();
            deligatepointer mydelegate =p.print;
            mydelegate += p.display;
            mydelegate();
            mydelegate -= p.display;
            mydelegate();
            deligatepointer mydelegate1 = p.print1;
            mydelegate1();
            Calculate c = new Calculate();
            circledeligatepointer mydelegate3 = c.circle;
           Console.WriteLine( mydelegate3(4));
            Console.ReadKey();
        }
        public void print()
        {
            Console.WriteLine("welcome");
        }
        public void print1()
        {
            Console.WriteLine("welcome");
        }
        public void display()
        {
            Console.WriteLine("hello");
        }
    }
}
