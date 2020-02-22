using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
         public static void evenodd()
        {
            Console.WriteLine("enter number to check even or odd");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine(a + " is even number");
            else
                Console.WriteLine(a + " is odd number");
        }
        public static void Natural()
        {
            Console.WriteLine("enter number for Natural numbers");
            int a = int.Parse(Console.ReadLine());
            for(int i = 1; i <= a; i++)
            {
                Console.WriteLine(i + " ");
            }
        }
        public static void multiplication()
        {
            Console.WriteLine("enter number for multiplication table");
            int a = int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(a + "*" + i + "=" + a * i);
            }
        }
        static void Main(string[] args)
        {
        
            char d;
            
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Even/odd");
                Console.WriteLine("2.Natural numbers");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Exit");
                Console.WriteLine("enter number");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        evenodd();
                        break;
                    case 2:
                        Natural();
                        break;
                    case 3:
                        multiplication();
                        break;
                    case 4: Environment.Exit(0);
                        break;
                       
                    default:
                        Console.WriteLine("user does not enter correct choice");
                        break;

                }
                Console.WriteLine("do you want to continue");
                d = char.Parse(Console.ReadLine());
            } while (d !='y');
            Console.ReadKey();
        }
    }
}
