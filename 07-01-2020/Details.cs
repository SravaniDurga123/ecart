using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{

    class Details
    {
      private  String rollno;
       private String name { get; set; }
      private  int sem;
       private String branch;
       private double marks;
        public String Rollno
        {
            get
            {
                return rollno;
            }
            set
            {
                rollno = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Sem
        {
            get
            {
                return sem;
            }
            set
            {
                sem = value;
            }
        }
        private string Branch 
        {
            get
            {
                return branch;
            }

            set
            {
                branch = value;
            }
        }
        public double Marks
        {
            get
            {
                return marks;
            }
        }

        public void AcceptStudentDetails()
        {
          
            Console.WriteLine("student details are accepted");
            Console.WriteLine("enter marks");
            this.marks =int.Parse( Console.ReadLine());
            Console.WriteLine("enter branch");
            this.branch = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            
            Console.WriteLine("student details");
            Console.WriteLine(this.Name  + "\n" + this.Rollno + "\n" + this.Branch + "\n" + this.Sem + "\n" + this.Marks);
           
        }
    }
}
