using Lab06.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab06.DAL
{
    public class Model1 : DbContext
    {
        public virtual DbSet<LoaiSach> LoaiSachs { get; set; }
        public virtual DbSet<Sach> Sachs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=QLSach;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiSach>().HasData(
                new LoaiSach { MaLoai = 1, TenLoai = "Khoa Học" },
                new LoaiSach { MaLoai = 2, TenLoai = "Y học" },
                new LoaiSach { MaLoai = 3, TenLoai = "Đời sống" }
            );

            modelBuilder.Entity<Sach>().HasData(
                new Sach { MaSach = "KH0001", TenSach = "Khám phá sự sống", NamXB = 2018, MaLoai = 1 },
                new Sach { MaSach = "KH0002", TenSach = "Hải dương học", NamXB = 2018, MaLoai = 1 },
                new Sach { MaSach = "YH0001", TenSach = "Chuẩn đoán và điều trị", NamXB = 2020, MaLoai = 2 }
            );
        }
    }
}