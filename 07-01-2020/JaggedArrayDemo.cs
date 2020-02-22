using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class JaggedArrayDemo
    {
        static void Main()
        {
            int[][] a = new int[2][];
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("enter column size of r" + i);
                int r = int.Parse(Console.ReadLine());
                a[i] = new int[r];
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
                    int sum = 0,x=0,s=0;
            for(int i=0;i<2;i++)
            {
                
                for(int j=0;j<a[i].Length;j++)
                {
                    x = a[i][j];
                    sum = a[i][j];
                    for (int k = j + 1; k < a[i].Length; k++)
                    {
                        if (a[i][j] == a[i][k])
                            sum += a[i][j];
                        //Console.WriteLine("sum "+sum);
                    }
                    if (x != sum)
                    {
                        s += sum;
                        //Console.WriteLine("s " + s);
                    }
                    else
                        sum = 0;

                }
            }
            if (s != 0)
                Console.WriteLine("sum of common elements are "+s);
            else
                Console.WriteLine("No Commom Elements");
            Console.ReadKey();
        }
    }
}
