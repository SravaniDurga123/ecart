using System;

namespace PartialDemo
{
    partial class ClassA
    {
        partial void setData();
        public void print()
        {
            Console.WriteLine("Class A Print");
            setData();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            
            a.print();
            Console.ReadLine();
        }
    }
}
