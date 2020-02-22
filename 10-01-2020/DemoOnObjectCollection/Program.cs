using System;
using System.Collections.Generic;

namespace DemoOnObjectCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee e = new Employee();
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("12345", "sravani", 2345));
            elist.Add(new Employee("2457", "kishore", 4570));
            elist.Add(new Employee("5679", "lavanya", 5675));
            List<Employee> highpay = elist.FindAll(e => e.salary > 1000);
            foreach(Employee E1 in highpay)
            {
                Console.WriteLine(E1.ToString());
            }

        }
    }
}
