using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditional
{
    class Program
    {
         public static string  even(int x)
        {
            if (x % 2 == 0)
                return "even";
            else
                return "odd";
        }
        public static int Max(int a,int b,int c)
        {
            if(a>b)
            {
                if (a > c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b > c)
                    return b;
                else
                    return c; 
            }
        }
        public  String Marks(double m1,double m2,double m3,double m4)
        {
            double avg = (m1 + m2 + m3 + m4) / 4;
            if (avg > 70)
                return "first class";
            else if ((avg >= 60) && (avg < 70))
                return "second class";
            else if ((avg >= 50) && (avg < 60))
                return "third class";
            else
                return "Fail";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter no");
            int i =int.Parse( Console.ReadLine()) ;
            String res=even(i);
            Console.WriteLine(res);
            int res1 = Max(2, 3, 4);
            Console.WriteLine(res1);
            Program p = new Program();
            Console.WriteLine(p.Marks(40.7,93.7,98,39.8);
            Console.ReadKey();
        }
    }
}
