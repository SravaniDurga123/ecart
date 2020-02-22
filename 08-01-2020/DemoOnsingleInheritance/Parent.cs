using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnInheritance
{
    class Parent
    {
        protected int a;
        protected int b;
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
        class Child:Parent
        {
            int c;
            public void Calculate()
            {
                c = this.a + this.b;
            Console.WriteLine(c);
            }
        }
   
}
