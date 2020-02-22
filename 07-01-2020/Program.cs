using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Details d = new Details();
            d.Name = "sravani";
            d.Rollno = "15a81a0589";
            d.Sem = 1;
            d.AcceptStudentDetails();
            d.DisplayDetails();
            Console.ReadKey();
        }
    }
}
