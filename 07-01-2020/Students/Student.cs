using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Student
    {
        static string collegename = "sri vasavi";
        string rollno;
        string name;
        string branch;
        char sec;
        int sem;
        int avg = 0;
        int[] a = new int[5];
        string cls = " ";
        public Student(string rollno, string name, string branch, char sec, int sem, int[] a)
        {
            this.rollno = rollno;
            this.name = name;
            this.branch = branch;
            this.sec = sec;
            this.sem = sem;
            this.a = a;
        } 
       
        public void calculate()
        {
            int sum = 0;
           
            foreach(int x in a)
            {
                sum = sum + x;
            }
           avg = sum / 5;
            foreach(int x in a)
            {
                if (x < 35)
                {
                    cls = "failed";
                    break;
                }
                else if (x > 35 && avg < 50)
                {
                    cls = "failed";
                    break;
                }
                else
                {
                    if (avg > 50) 
                    { 
                    cls = "passed";
                    break;
                   }
                }
                
            }
        }
        public void display()
        {
            Console.WriteLine(" ");
            Console.WriteLine("details");
            Console.WriteLine("college name:" + collegename);
            Console.WriteLine("roll number" + rollno);
            Console.WriteLine("name: " + name);
            Console.WriteLine("branch: " + branch);
            Console.WriteLine("section: " + sec);
            Console.WriteLine("semester: " + sem);
            Console.WriteLine("average:" + avg);
            Console.WriteLine("result" + cls);
        }
    }
}
