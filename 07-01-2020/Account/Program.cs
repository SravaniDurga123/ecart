using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter details");
           
            Console.WriteLine("enter transaction type");
            char trans_type = char.Parse(Console.ReadLine()) ;
            if (trans_type == 'd' || trans_type == 'D')
            {
                Calc c = new Calc(trans_type);
                Console.WriteLine("enter ammount to deposit");
                double amount = double.Parse(Console.ReadLine());
                c.credit(amount);
                c.ShowDetails();
            }

            else if (trans_type == 'w' || trans_type == 'W')
            {
                Calc c = new Calc(trans_type);
                Console.WriteLine("enter amount to withdraw");
                double amount = double.Parse(Console.ReadLine());
                c.withdraw(amount);
                c.ShowDetails();
            }
            else
                Console.WriteLine("enter d for deposit or w for withdraw");
            
            Console.ReadKey();  
        }
    }
}
