using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOnPolymorphism
{
    class Shape
    {
        int length;
        int width;
        int breadth;
        String name;
        public void draw()
        {
            Console.WriteLine("a shape can be drawn");
        }
           public void draw(int length,int width)
        {
            Console.WriteLine("a rectangle can be drawn");
        }
        public void draw(int length,int width,int breadth)
        {
            Console.WriteLine("a box can be drawn");
        }
        public void draw(int length, int width, int breadth,String name)
        {
            this.name = name;
            Console.WriteLine(name+" can be drawn");
        }
    }
}
