using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOnSingleton
{
   class Singleton
    {
        static int count;
       public static Singleton Instance=null;
        public static Singleton getInstance
        {
            get
            {
                if (Instance == null) 
                    return new Singleton();
                else return Instance;
            }
        }
       private Singleton()
        {
            count++;
            Console.WriteLine(count);
        }
       public void printDetails(string s)
        {
            Console.WriteLine("printing"+s);
        }
    }
}
