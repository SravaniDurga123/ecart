using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
   public interface Istudent
    {
        
        string name { get;  set; }
        string sid { get;  set; }

        public void ShowDetails();
    }
    abstract public  class Student
    {
       protected string name;
       protected string sid;
       protected int grade;
        public abstract Boolean Ispassed(int grade);
    }
   public  class UnderGraduate:Student 
        {
        public override Boolean Ispassed(int grade)
        {
            if (grade >= 70)
                return true;
            else
                return false;
        }
    }
    public class Graduate:Student
    {
        public override bool Ispassed(int grade)
        {
            if (grade >= 80)
                return true;
            else
                return false;
        }
    }
    public class DaysScholar: Istudent
    {
       
        string Name;
        string Sid;
        string Istudent.name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

       string Istudent.sid
        {
            get
            {
                return Sid;
            }
            set
            {
                Sid = value;
            }
        }
        public DaysScholar(string name,string sid)
        {
            this.Name = name;
            this.Sid = sid;
        }

        
        

        public  void ShowDetails()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Sid);

        }
    }
    public class Residence : Istudent
    {
        
        string Name;
        string Sid;
        string Istudent.name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        string Istudent.sid
        {
            get
            {
                return Sid;
            }
            set
            {
                Sid = value;
            }
        }
        public Residence(string name, string sid)
        {
            this.Name = name;
            this.Sid = sid;
        }
        public void ShowDetails()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Sid);

        }
    }
}
