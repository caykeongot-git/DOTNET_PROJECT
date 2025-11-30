using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_02
{
    internal class StudentsContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-LOPGOLER\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
