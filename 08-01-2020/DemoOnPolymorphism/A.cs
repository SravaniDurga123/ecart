using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOnPolymorphism
{
   abstract class A
    {
        public abstract void display();
        
    }
    class B:A
    {
        public override void display()
        {
            Console.WriteLine("display B class detaills");
        }
    }
    class C:A
    {
        public override void display()
        {
            Console.WriteLine("display C class detaills");
        }
    }
}
