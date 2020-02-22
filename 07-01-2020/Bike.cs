using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demooops
{
    class Bike
    {
        String name;
        String color;

      public void ShowDetails(String name,String Color)
        {
            Console.WriteLine("bike name" + name);
            Console.WriteLine("bike color" + color);
        }
        public void StartEnginee()
        {
            Console.WriteLine("bike is started at " + DateTime.Now);
        }
        public void FillGas(int liter)
        {
            Console.WriteLine("bike filled with " + liter + " liters");
        }
        public int Travel(int distance,int speed)
        {
            Console.WriteLine("you will reach your distination in ");
            int x =(int) distance / speed;
            return x;
        }
       
    }
}
