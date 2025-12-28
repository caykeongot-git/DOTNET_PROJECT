using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab06.DAL.Models
{
    public class Sach
    {
        [Key] [StringLength(6)] public string MaSach { get; set; }

        [Required] [StringLength(150)] public string TenSach { get; set; }

        public int NamXB { get; set; }

        public int MaLoai { get; set; }

        [ForeignKey("MaLoai")] public virtual LoaiSach LoaiSach { get; set; }
    }
}