using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnVariables
{
    class Program
    {
        String name;
        static double salary;
        static void Main(string[] args)
        {
            int i = 60;
            int[] a = new int[4] { 4, 5, 6, 7 };
            Console.WriteLine(i);
            for(int x=0;x<4;x++)
            {
                Console.WriteLine(a[x]);
            }
            Program obj = new Program();
            Console.WriteLine(obj.name);
            Console.WriteLine(Program.salary);
            Console.WriteLine();
            Object O = 3;
             O = 'S';
            Console.WriteLine(O);
            int k = 3;
           String n = "sffjfsd";
            Console.WriteLine("name:{0} age:{1}", n, k);
            
            Console.ReadKey();
        }
    }
}
