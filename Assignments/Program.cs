using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Program
    {
          public static void Display()
          {
              Console.WriteLine("Welcome to the world of C#");
          } 
         public static void DisplayName()
         {
             Console.WriteLine("enter name");
             String s = Console.ReadLine();
             Console.WriteLine("Hi "+s+" Welcome to the world of c#");
         }
          public static void DisplayNumbers()
          {
              Console.WriteLine("ENTER NUMBERS");
              int a = int.Parse(Console.ReadLine());
              int b = int.Parse(Console.ReadLine());
              for (int i = a; i <= b; i++)
                  Console.Write(i+" ");
          } 
          public static void DisplayEvenorOdd()
          {
              Console.WriteLine("ENTER NUMBER");
              int a=int.Parse(Console.ReadLine());
              if (a % 2 == 0)
                  Console.WriteLine(a + " " + " is even number");
              else
                  Console.WriteLine(a + " " + " is odd number");
          }

           public static void Displaycount()
        {
            Console.WriteLine("enter n:");
           int n= int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("enter" + n + "numbers");
            for(int i = 0; i < n; i++)
            {
                a[i] =int.Parse( Console.ReadLine());
            }
            int c1 = 0, c2 = 0;
            for(int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                    c1++;
                else
                    c2++;
            }
            Console.WriteLine("even: " + c1);
            Console.WriteLine("odd: " + c2);
        }
         public static void CelsiusConversion()
          {
              Console.WriteLine("enter Farenheit to convert");
              int f = int.Parse(Console.ReadLine());
              int cel = ((f - 32) * 5) / 9;
              Console.WriteLine("in celsius: " + cel);
          } 
        public static void ProductsCalculation()
        {
          
                Console.WriteLine("---MENU--");
                Console.WriteLine("Product 1=22.5");
                Console.WriteLine("product 2=44.50");
                Console.WriteLine("product 3=9.98");
                double[] p = new double[3];
                p[0] = 22.4;
                p[1] = 44.50;
                p[2] = 9.98;
               
                int[] a = new int[3];
            Console.WriteLine("enter product numbers and quantiry sold");
            for (int i = 0; i < 3; i++)
                {
                    
                    Console.WriteLine("enter quantity  for product numner "+(i+1));
                    a[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("----Total List----");
                Console.WriteLine("products" + "\t" + "quantity" + "\t" + "total cost");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(p[i] + "\t"+"\t" + a[i] + "\t"+"\t" + (a[i] * p[i]));
                }
           
        }
     public static void Series()
        {
            for(int i = 1; i <= 25; i++)
            {
                Console.Write(i * i + ",");
            }
        } 
       public static void Factorial()
        {
            int f = 1;
            Console.WriteLine("enter number to find factorial");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                f = f * i;
            }
            Console.WriteLine("factorial of " + n + " is " + f);
        }
       public static void Fibonacci()
        {
            
            int a = 0, b = 1;
            Console.Write(a + " " + b + " ");
            while ((a+b)<40)
            {
                int c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
        public static void Multiplication()
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(n + "*" + i + "=" + (n * i));
            }
        }
        public static void Divisibleby7()
        {
            int a = 200, b = 300;
            for(int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                    Console.Write(i + ",");
            }
        }
       public static void Largeof3()
        {
            Console.WriteLine("enter 4 numbers");
            int[] a = new int[3];
            for(int i=0;i<3;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(a);
            Console.WriteLine("largest number "+ a[2]);
        }
       public static void Smallestof5()
        {
            Console.WriteLine("enter 5 numbers");
            int[] a = new int[5];
            for(int i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(a);
            Console.WriteLine("Smallest number " + a[0]);
        }
        public static void Marks()
        {
            int[] a = new int[10];
            Console.WriteLine("enter 10 marks");
            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int s = 0;
            for (int i = 0; i < 10; i++)
            {
                s += a[i];
            }
            int avg = s / 10;
            Array.Sort(a);
            Console.WriteLine("Total marks: " + s);
            Console.WriteLine("average of total marks: " + avg);
            Console.WriteLine("minimum marks: " + a[0]);
            Console.WriteLine("maximum marks: " + a[9]);
            Console.WriteLine("marks in ascending order:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("\n marks in desending order:");
            for (int i = 9; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }
        }
        
        public static void length()
        {
            Console.WriteLine("enter word");
            String s = Console.ReadLine();
            int n =s.Length;
            
            Console.WriteLine("length of the given word: " + n);
        }
       public static void Equal()
        {
            Console.WriteLine("enter two words");
            String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();    
           if(s1.Equals(s2))
                Console.WriteLine("two words are equal");
            else
                Console.WriteLine("two words are not equal");
        }
        public static void ReverseString()
        {
            Console.WriteLine("enter string");
            String s = Console.ReadLine();
            char[] a = s.ToArray();
            Array.Reverse(a);
            String s1 = a.ToString();
            Console.WriteLine(s1);
        }
        public static void palindrome()
        {
            Console.WriteLine("enter string");
            String s = Console.ReadLine();
            String s1 = s;
            char[] a = s1.ToArray();
            Array.Reverse(a);
            String s2 = new String(a);
            if (s.Equals(s2))
                Console.WriteLine("palindrome");
            else
                Console.WriteLine("not a palindrome");
        }
        static void Main(string[] args)
        {
              Display();
            DisplayName();
             DisplayNumbers();
            DisplayEvenorOdd();
             Displaycount();
              CelsiusConversion();
             ProductsCalculation();
             Series();
             Factorial();
            Fibonacci();
             Multiplication();
             Divisibleby7();
             Largeof3();
             Smallestof5();
           Marks();
             length();
             Equal();
            ReverseString();
            palindrome();
            Console.ReadKey();

        }
    }
}
