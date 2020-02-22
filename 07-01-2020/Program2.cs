using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single Dimensional Array
             Console.WriteLine("enter n :");
             int n = int.Parse(Console.ReadLine());
             int[] a = new int[n];
             
            for (int i = 0; i < n; i++)
                 a[i]= int.Parse(Console.ReadLine());
             //Array.Sort(a);
             int l = a[0], s = a[0];
             for(int i=0;i<n;i++)
             {
                 if (l < a[i]) l = a[i];
                 if (s > a[i]) s = a[i];
             }
             Console.WriteLine("Largest no. in given numbers is "+l);
             Console.WriteLine("Smallest no. in given numbers is " + s);

            // Two Dimensional Array
            Console.WriteLine("enter no. of elements in row :");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("enter no. of elements in row :");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("enter no. in array:");
            int[,] a = new int[r,c];
            for (int i = 0; i < r; i++)
                for(int j=0;j<c;j++)
                a[i,j] = int.Parse(Console.ReadLine());

            Console.Write(" \n");

                        Console.Write(" \n");for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write(a[i, j] + " ");
                Console.Write(" \n");
            }

            int l;
            for (int i = 0; i < c; i++)
            {
                l = a[0,i];
                for (int j = 0; j < r; j++)
                    if (a[j,i] > l)
                        l = a[j,i];
                    Console.Write("highest score in " +(i+1)+ " is "+l);
                Console.Write("\n");
            }

            //Jagged Array
            string[][] names = new string[3][];
            for (int i = 0; i < 3; i++)
            {
                int size = int.Parse(Console.ReadLine());
                names[i] = new string[size];
            }
            Console.Write("enter elements:");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < names[i].Length; j++)
                    names[i][j] = Console.ReadLine();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < names[i].Length; j++)
                        Console.Write(names[i][j] + " ");
                    Console.Write(" \n");
                }


                Console.ReadKey();


            }
        }
    }

