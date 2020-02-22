using System;
using System.Linq;
using System.Collections.Generic;
namespace DemoOnDelegate1
{
    public delegate double caldelegatepointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            //caldelegatepointer cptr = new caldelegatepointer(calarea);
            //double area = cptr(12);
            //Console.WriteLine(area);
            //Console.ReadKey();
            caldelegatepointer cptr = new caldelegatepointer(delegate (double r)
              {
                  return 3.14 * r * r;
              });
            double area = cptr(12);
            Console.WriteLine(area);


            caldelegatepointer cptr1 = (r => 3.14 * r * r);
            double area1 = cptr1(10);
            Console.WriteLine(area1);

            //function delegate

            Func<double, double> f1 = (r => 3.14 * r * r);
            double a = f1(3);
            Console.WriteLine(a);

            //Action delegate

            Action<string> act = (x => Console.WriteLine(x));
            act("4");

            //predicate
            Predicate<string> pt = (y => y.Length > 3);
            Console.WriteLine(pt("cts"));

            int[] A = new int[5] { 1, 2, 3, 4, 5 };
            int x = A.Count(x => x > 2);
            Console.WriteLine(x);
            List<string> l = new List<string>();
            l.Add("chinni");
            l.Add("chinnu");
            l.Add("Bannu");
            List<string> s = l.FindAll(y => y.Contains('i'));
            foreach(string n in s)
            {
                Console.WriteLine(n);
            }
            //public static double calarea(double a)
            //{
            //    return a * a;
            //}
        }
    }
}
