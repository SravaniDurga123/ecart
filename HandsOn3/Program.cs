using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn3
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte i = sbyte.Parse("123");
            Console.WriteLine(i);
            bool b = bool.Parse("true");
            Console.WriteLine(b);

            String b1 = Console.ReadLine();
            int a = int.Parse(b1);
            Console.WriteLine(a);
            string s = "100";
            int x = int.Parse(s);
            double d = double.Parse(s);
            Console.WriteLine("{0} {1}",x,d);
               Console.ReadKey();
        }
            
        
    }
}
