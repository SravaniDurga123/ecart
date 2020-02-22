using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter roll number");
            string rolno = Console.ReadLine();
            Console.WriteLine("enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("enter branch");
            string branch = Console.ReadLine();
            Console.WriteLine("enter section");
            char sec = char.Parse(Console.ReadLine());
            Console.WriteLine("enter semster");
            int sem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 5 subject marks");
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Student S = new Student(rolno,name,branch,sec,sem,a);
            S.calculate();
            S.display();
            Console.ReadKey();
        }
    }
}
