using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_02
{
    internal class Student
    {
        [Key] public string Id { get; set; }
        public string FullName { get; set; }
        public string Sex { get; set; }
        public double GPA { get; set; }
        public string Faculty { get; set; }
    }
}
