
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demooops
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike b = new Bike();
            b.StartEnginee();
            Console.WriteLine("enter bike name:");
            String name = Console.ReadLine();
            Console.WriteLine("enter bike color");
            String color = Console.ReadLine();
           
            Console.WriteLine("enter liters to be filled");
            int x = int.Parse(Console.ReadLine());
           
            Console.WriteLine("enter distance to be tavelled and at what speed");
            int y= int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            b.ShowDetails(name, color);
            b.FillGas(x);
            Console.WriteLine( b.Travel(y,z));
            Console.ReadKey();
        }
    }
}
