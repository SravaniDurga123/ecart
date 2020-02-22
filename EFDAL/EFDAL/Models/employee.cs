using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFDAL.Models
{
    [Table("Employee")]
   public class employee
    {
       [Key]
       [StringLength(5)]
       public string eid { get; set; }
        [Required]
        [StringLength(30)]
        public string ename { get; set; }
        [Column(TypeName ="Date")]
        public DateTime? joindate { get; set; }
        [StringLength(20)]
        public string designation { get; set; }
        public decimal? salary { get; set; }

        public int pid { get; set; }
        //navigation property
        [ForeignKey("pid")]
        public project project { get; set; }
    }
}
