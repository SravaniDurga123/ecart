using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DemoOnThreading
{
    class ThreadClass
    {
        public void CountEven()
        {
            for(int i = 0; i < 10; i++)
            {
                if (i == 3)
                    Thread.Sleep(2000);
                if (i % 2 == 0)
                    Console.WriteLine(i);
                            }
        }
        public void CountOdd()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
