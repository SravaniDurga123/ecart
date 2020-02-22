using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOnObjectCollection
{
    class Employee
    {
        string emid;
        string name;
      public  int salary;
        public Employee()
        {

        }
        public Employee(string emid, string name, int salary)
        {
            this.emid = emid;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            return this.name;
        }
        public override bool Equals(object obj)
        {
            Employee temp = (Employee)obj;
            if (this.emid == temp.emid && this.name == temp.name)
                return true;
            else
                return false;
        }
    }
}
