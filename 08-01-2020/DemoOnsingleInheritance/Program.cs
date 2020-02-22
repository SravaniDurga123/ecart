using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Child c = new Child();
            c.getvalues(3, 5);
            c.display();
                c.Calculate();
            Console.ReadKey();
       }
    }
}
