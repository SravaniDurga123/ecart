using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EFDAL.Models
{
    [Table("project")]
   public class project
    {
        [Key] //set primary key
        public int pid { get; set; }
        [Required]
        [StringLength(30)]
   
        public string pname { get; set; }
        [Column(TypeName ="Date")]
        public DateTime? startdate { get; set; }
        [Column(TypeName ="Date")]
        public DateTime? enddate { get; set; }
        //set one to many relation with employee
        public IEnumerable<employee> employees { get; set; }

    }
}
