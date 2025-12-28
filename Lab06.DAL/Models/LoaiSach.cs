using Lab06.DAL.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab06.DAL.Models
{
    public class LoaiSach
    {
        [Key] public int MaLoai { get; set; }
        [Required] [StringLength(50)] public string TenLoai { get; set; }
        public virtual ICollection<Sach> Sachs { get; set; }
    }
}