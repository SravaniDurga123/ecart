using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOnConstructor
{
    class Vehicle
    {
        string color;
        public Vehicle()
        {
            color = "blue";
        }
        public void start()
        {
            Console.WriteLine("vehicle started");
        }
        public void stop()
        {
            Console.WriteLine("vehicle is stopped");
        }
        public void display()
        {
            Console.WriteLine("color" + color);
        }
    }
    class Bus:Vehicle
    {
        public void run()
        {
            Console.WriteLine("bus in on halt condition");
        }
    }
    class Car:Vehicle
    {
        public void drive()
        {
            Console.WriteLine("car is driving");
        }
    }
}
