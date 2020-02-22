using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnInheritance
{
    class Parent
    {
        int a;
         int b;
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public void getvalues(int a, int b)
        {
            this.A = a;
            this.B = b;
        }
        public void display()
        {
            Console.WriteLine("a=" + a + "b=" + b);

        }
    }
    class Child : Parent
    {
        protected int c;
        public void Calculate()
        {
            c = this.A + this.B;
            Console.WriteLine(c);
        }
    }
    class Grandchild:Child
    {
        int x;
        public void multiple()
        {
            x = this.A + this.B + this.c;
           
            Console.WriteLine(x);
        }
    }

}

namespace demoProtected
{
    class exchild : DemoOnInheritance.Parent
    {
      public void show()
        {
            Console.WriteLine("a=" + this.A + "b=" + this.B);
        }
    }
    
}