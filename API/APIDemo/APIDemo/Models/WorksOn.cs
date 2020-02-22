using System;
using System.Collections.Generic;

namespace APIDemo.Models
{
    public partial class WorksOn
    {
        public int? EmpNo { get; set; }
        public string ProjectNo { get; set; }
        public string Job { get; set; }
        public DateTime? EnterDate { get; set; }
    }
}
