using System;

namespace DemoOnPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape();
            //s.draw();
            //s.draw(10,20);
            //s.draw(10,20,30);
            //s.draw(10,20,30,"paralellogram");
            //A a = new A();
            //a.display();
            //B b = new B();
            //b.display();
            //C c = new C();
            //c.display();
            A a ;
        
            a = new B();
            a.display();
            a = new C();
            a.display();
        }
    }
}
