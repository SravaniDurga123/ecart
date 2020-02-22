using System;
using System.Collections.Generic;

namespace DemoOnStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "welcome";
            //Console.WriteLine(s.Length);
            //Console.WriteLine(s.Replace('c', 'k'));
            //Console.WriteLine(s.ToLower());
            //Console.WriteLine(s.ToUpper());
            //Console.WriteLine(s.Remove(0,5));
            //Console.WriteLine(s.LastIndexOf('e'));
            //Console.WriteLine(s.Substring(0, 3));
            //Console.WriteLine(s.Trim('e'));
            //Console.WriteLine(s.Contains('l'));
            //Console.WriteLine(s.StartsWith('w'));
            //Console.WriteLine(s.EndsWith('R'));
            //int n = string.Compare("welcome", 3, "come",0,4, StringComparison.InvariantCultureIgnoreCase);
            //Console.WriteLine(n);
            //string s1 = "hello";
            //string s2 = "HELLO";
            //Console.WriteLine(s1.Equals(s2));
            //Console.WriteLine(s1.CompareTo(s2));
            //Console.WriteLine(string.Compare("hello", 0, "HELLO", 0, 5, StringComparison.InvariantCultureIgnoreCase));
            ////Console.WriteLine("N1:"+n1);
            //string input = Console.ReadLine();
            //string[] data = input.Split(' ');
            //foreach (string x in data)
            //Console.WriteLine(x);
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString());
            Console.WriteLine(dt.ToString("dddd/mmmm/yyyy"));

            Employee[] e = new Employee[3] {new Employee("a","123",3456),
                                           new Employee("b","456",34567),
                                            new Employee("c","678",8906)};
            foreach(Employee e1 in e)
            {
                Console.WriteLine(e1.ToString());
            }

           List<Employee> l = new List<Employee>();
            l.Add(new Employee("D", "123", 3456));
            l.Add(new Employee("E", "456", 34567));
            l.Add(new Employee("F", "678", 8906));
            foreach (Employee e2 in l)
                Console.WriteLine(e2.ToString());


            Employee e3 = new Employee("1", "ram", 2020);
            Employee e4 = new Employee("1", "ram", 2020);
            if (e3.Equals(e4))
                Console.WriteLine("same");
            Console.ReadKey();

        }
    }
}
