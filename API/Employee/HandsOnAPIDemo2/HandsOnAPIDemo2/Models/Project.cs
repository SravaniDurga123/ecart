using System;
using System.Collections.Generic;

namespace HandsOnAPIDemo2.Models
{
    public partial class Project
    {
        public Project()
        {
            Employee = new HashSet<Employee>();
        }

        public int Pid { get; set; }
        public string Pname { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? Startdate { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
