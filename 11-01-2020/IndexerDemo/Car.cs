using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerDemo
{
    class Car
    {
        int year;
        public string[] a=new string[4];

        public int Year { get => year; set => year = value; }
       // public string A { get => a[]; set => a = value; }
        
        public string this[int x]
        {
            get
            {
                return a[x];
            }
            set
            {
                a[x] = value;
            }
        }
        public void display()
        {
            foreach(String val in a)
            {
                Console.WriteLine(val);
            }
        }
    }
}
