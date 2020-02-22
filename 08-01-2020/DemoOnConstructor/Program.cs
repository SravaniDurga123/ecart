using System;

namespace DemoOnConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.start();
            c.display();
            c.drive();
            c.stop();
            Bus b = new Bus();
            b.start();
            b.display();
            b.run();
            b.stop();
            Console.ReadKey();
        }
    }
}
