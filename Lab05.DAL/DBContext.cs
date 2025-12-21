using Lab05.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.DAL
{
    public class DBContext : DbContext
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Major> Majors { get; set; } 
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Lab05DB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Major>()
                .HasKey(m => new { m.FacultyID, m.MajorID });

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Major)
                .WithMany(m => m.Students)
                .HasForeignKey(s => new { s.FacultyID, s.MajorID })
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
