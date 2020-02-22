using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            double d = 10.4;
            float f = 12.4f;
            char c = 'a';
            //boxing
            object o1 = i;
            object o2 = d;
            object o3 = f;
            object o4 = c;
            Console.WriteLine("{0} {1} {2} {3}", o1, o2, o3, o4);
            //unboxing

            int i1 = (int)o1;
            double d1 = (double)o2;
            float f1 = (float)o3;
            char c1 = (char)o4;
            Console.WriteLine("{0} {1} {2} {3}", i1, d1, f1, c1);
            
            //covert int to string

            String s = o1.ToString();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
