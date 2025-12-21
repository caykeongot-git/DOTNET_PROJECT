using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.DAL.Models
{
    public class Faculty
    {
        [Key] public int FacultyID { get; set; }

        [Required] [StringLength(200)] public string FacultyName { get; set; }

        public virtual ICollection<Major> Majors { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
