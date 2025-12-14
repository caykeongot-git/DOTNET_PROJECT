using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Lab04_01.DAL.Entities
{
    public class Faculty
    {
        [Key] public string FacultyID { get; set; }
        [Required][MaxLength(50)] public string FacultyName { get; set; } = string.Empty;
        public int? TotalProfessor { get; set; }  

        public virtual ICollection<Student> Students { get; set; }
    }
}
