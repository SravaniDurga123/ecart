using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("hello world");
            Console.WriteLine("enter name");
            String name = Console.ReadLine();
            Console.WriteLine("hello"+" " + name);
            Console.ReadKey();
        }
    }
}
