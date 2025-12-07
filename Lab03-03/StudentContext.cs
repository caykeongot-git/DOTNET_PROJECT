using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab03_03
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=.\\SQLEXPRESS;Database=StudentLab0303DB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
