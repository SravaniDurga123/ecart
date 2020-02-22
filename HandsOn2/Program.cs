using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn2
{
    class Program
    {
        static void Main(string[] args)
        {
            long l1 = 12000;
            int i1 = (int)l1;
            Console.WriteLine(i1);
            float f1 = 12f;
            int i2 = (int)f1;
            Console.WriteLine(i2);
            float b1 = 1f;
            int b2 = 2;
            float b3 = b1 + b2;
            Console.WriteLine(b3);
            Console.ReadKey();

        }
    }
}
