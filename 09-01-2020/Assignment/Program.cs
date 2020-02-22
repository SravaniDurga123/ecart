using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student id");
            string sid = Console.ReadLine();
            Console.WriteLine("enter grade");
            int n = int.Parse(Console.ReadLine());
            UnderGraduate ug = new UnderGraduate();
            Console.WriteLine("name: " + name);
            Console.WriteLine("student id: " + sid);
            if (ug.Ispassed(n) == true)
                Console.WriteLine("under graduation:passed ");
            else
                Console.WriteLine("under graduation:failed ");
            Graduate g = new Graduate();
            if(g.Ispassed(n)==true)
            Console.WriteLine("graduation:passed " );
            else
                Console.WriteLine("graduation:failed ");
            DaysScholar ds = new DaysScholar("sravani", "435");
                ds.ShowDetails();
            Residence rs = new Residence("sravani", "435");
            rs.ShowDetails();
            Console.ReadKey();
        }
    }
}
