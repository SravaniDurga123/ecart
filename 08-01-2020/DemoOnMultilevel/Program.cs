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

            Grandchild c = new Grandchild();
            c.getvalues(3, 5);
            c.display();
            c.Calculate();
            c.multiple();
            demoProtected.exchild ex = new demoProtected.exchild();
            ex.getvalues(5,4);
            ex.show();
            Console.ReadKey();
        }
    }
}
