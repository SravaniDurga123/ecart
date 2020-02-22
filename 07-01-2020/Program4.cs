using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.add();
            int a = int.Parse(Console.ReadLine());
          int b=  int.Parse(Console.ReadLine());
            c.swap(ref a,ref b);
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            
            Console.ReadKey();
        }

    }
}
