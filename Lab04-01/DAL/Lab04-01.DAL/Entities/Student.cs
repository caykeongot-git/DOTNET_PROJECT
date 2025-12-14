using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab04_01.DAL.Entities
{
    public class Student
    {
        [Key] public string StudentID { get; set; }
        [Required] [MaxLength(100)] public string StudentName { get; set; }
        public double AverageScore { get; set; }

        public string FacultyID { get; set; }
        [ForeignKey("FacultyID")] public virtual Faculty Faculty {  get; set; }

    }
}
