using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter n which should be odd");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            if(n%2!=0)
            {
                Console.WriteLine("enter " + n + " numbers");
                for (int i = 0; i < n; i++)
                    a[i] = int.Parse(Console.ReadLine());
                    int h = a[0];
                if (h < a[n / 2])
                    h = a[n / 2];
                if (h < a[n - 1])
                    h = a[n - 1];
                Console.WriteLine("highest element is " + h);
            }
            else
                Console.WriteLine("n should be odd number ");
            Console.ReadKey();

        }
    }
}
