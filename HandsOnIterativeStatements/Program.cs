using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIterativeStatements
{
    class Program
    {
      /* public static void Greet(int a,int b)
        {
            
            while (a <= b)
            {
                Console.WriteLine(a+" ");
                a++;
            }
        }
        public static void oddnum(int c)
        {
            do
            {
                if (c % 2 != 0)
                    Console.WriteLine(c);
                c++;
            } while (c <= 10);
        }
        public static int Factorial(int f)
         {
             int s = 1;
             for(int i=1;i<=f;i++)
             {
                 s = i * s;

             }
             return s;
         }
         public static int Factorial(int f)
          {
              int i = 1,s=1;
              for(;i<=f;i++)
              {
                  s = i * s;
              }
              return s;
          }
          
          public static int Factorial(int f)
          {
              int i = 1, s = 1;
              for (; i <= f;)
              {
                  s = i * s;
                  i++;
              }
              return s;
          }
          
        public static int Factorial(int f)
        {
            int i = 1, s = 1;
            for(; ; )
            {
                if (i <= f)
                {
                    s = i * s;
                    i++;
                }
                else
                    break;
            }
            return s;
        }

        public static void DisplayEven(int n)
        {
            for(int i=1;i<=n;i++)
            {
                if (i % 2 == 1)
                    continue;
                 Console.WriteLine(i + "\t");
            }
        }
     */   
        public static string CheckingVowel(char c)
        {
            switch (c)
            {
                case 'a': return c+ " is a vowel";
                           break;
 
                case 'e': return c+ " is a vowel";
                           break;
                case 'i': return  c+ " is a vowel";
                           break;
                case 'o': return  c+ " is a vowel";
                           break;
                case 'u': return c+ " is a vowel";
                           break;
                default:
                        return  c+ " is not vowel";
                         break;
            }
        }
        static void Main(string[] args)
        {

            /* int a = int.Parse(Console.ReadLine());
             int b = int.Parse(Console.ReadLine());
             Greet(a,b);
             Console.WriteLine("-------");
             oddnum(1);
             Console.WriteLine("---factorail---");
             int fact = int.Parse(Console.ReadLine());
             Console.WriteLine(Factorial(fact));
             Console.WriteLine("-----");
             DisplayEven(6); */
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(CheckingVowel(ch));
            Console.ReadKey();
        }
    }
}
