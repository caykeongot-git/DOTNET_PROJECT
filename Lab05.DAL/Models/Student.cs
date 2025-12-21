using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.DAL.Models
{
    public class Student
    {
        [Key] [StringLength(20)] public string StudentID { get; set; } 

        [Required] [StringLength(200)] public string FullName { get; set; }

        public double AverageScore { get; set; }

        public string? Avatar { get; set; }

        public int FacultyID { get; set; }

        public int? MajorID { get; set; }

        [ForeignKey("FacultyID")]
        public virtual Faculty Faculty { get; set; }

        public virtual Major Major { get; set; }
    }
}
