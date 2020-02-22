using System;
using System.Collections.Generic;

namespace HandsOnAPIDemo2.Models
{
    public partial class Employee
    {
        public string Eid { get; set; }
        public string Ename { get; set; }
        public DateTime? Joindate { get; set; }
        public string Designation { get; set; }
        public decimal? Salary { get; set; }
        public int Pid { get; set; }

        public virtual Project P { get; set; }
    }
}
