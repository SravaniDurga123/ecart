using System;
using System.Collections.Generic;
using System.Text;

namespace CrudApp
{
    public class Employee
    {
        private int id;
        private string en, ed;

        public int Id { get => id; set => id = value; }
        public string En { get => en; set => en = value; }
        public string Ed { get => ed; set => ed = value; }

        public Employee(int id,string en,string ed)
            {
            this.Id = id;
            this.en = en;
            this.ed = ed;
            }
       
          
           
        }
    }

