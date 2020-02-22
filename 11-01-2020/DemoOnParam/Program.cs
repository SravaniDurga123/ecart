using System;

namespace DemoOnParam
{
    class Calculator
    {
        public void Add(params int[] x)
        {
            int res=0;
            foreach (int i in x) res += i;
            Console.WriteLine(res);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Add(2, 3,5);
        }
    }
}
