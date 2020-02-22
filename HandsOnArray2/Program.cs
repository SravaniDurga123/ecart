using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArray2
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] names = new string[8]
            {
                "rohan",
                "raju",
            "krishna",
            "vijay",
            "vamsi",
            "lavanya",
            "sravani",
            "joshi",

            };
            Console.WriteLine("enter string");
            String s = Console.ReadLine();
            int f = 0;
            foreach (String n in names)
            {
                if (s.Equals(n))
                {
                    f = 1;
                }


            }
            if (f == 1)
                Console.WriteLine("present");
            else
                Console.WriteLine("not present");
            Console.ReadKey();

        }
    }
}
