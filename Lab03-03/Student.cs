using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Lab03_03
{
    public class Student
    {
        public double _averageScore = 0;
        [Key] public string Id { get; set; }
        [Required] [MaxLength(100)] public string FullName { get; set; }
        [MaxLength(50)] public string Faculty { get; set; }
        [Required] public double AverageScore {
            get { return _averageScore; }
            set {
                if (value < 0 || value > 10) _averageScore = 0;
                else _averageScore = value;
            }
        }
    }
}
