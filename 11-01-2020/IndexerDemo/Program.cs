using System;

namespace IndexerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Year = 2020;
            c[0] = "hai";
            c[1] = "one";
            c.display();
        }
    }
}
