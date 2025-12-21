using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.DAL.Models
{
    public class Major
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] public int MajorID { get; set; }

        [Required] [StringLength(200)] public string Name { get; set; }

        public int FacultyID { get; set; } 

        [ForeignKey("FacultyID")]
        public virtual Faculty Faculty { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
