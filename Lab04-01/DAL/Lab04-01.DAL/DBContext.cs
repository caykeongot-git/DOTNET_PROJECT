using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab04_01.DAL.Entities;
using Microsoft.EntityFrameworkCore;
namespace Lab04_01.DAL
{
    public class DBContext : DbContext
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=.\\SQLEXPRESS;Database=Lab0401;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Faculty>().HasData(
                new Faculty { FacultyID = "CNTT", FacultyName = "Công Nghệ Thông Tin" },
                new Faculty { FacultyID = "NNA", FacultyName = "Ngôn Ngữ Anh" },
                new Faculty { FacultyID = "QTKD", FacultyName = "Quản Trị Kinh Doanh" },
                new Faculty { FacultyID = "DAAH", FacultyName = "DO ALL AT HOME" }
            );
        }
    }
}
