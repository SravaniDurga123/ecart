using System;
using System.Threading;
namespace DemoOnThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadClass tc = new ThreadClass();
            Thread t = new Thread(tc.CountEven);
            Thread t1 = new Thread(tc.CountOdd);
            t.Priority = ThreadPriority.Lowest;
            t1.Priority = ThreadPriority.Highest;
            t.Start();
            t1.Start();
            Console.ReadKey();
        }
    }
}
