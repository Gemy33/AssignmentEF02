using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.InfraStructure
{
    internal class ITI02: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITI02;Trusted_Connection=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ITI02).Assembly);
        }
        public DbSet<Domain.Topic> Topics { get; set; }
        public DbSet<Domain.Course> Courses { get; set; }
        public DbSet<Domain.Instructor> Instructors { get; set; }
        public DbSet<Domain.Department> Departments { get; set; }

        public DbSet<Domain.Student> students { get; set; }
        public DbSet<Domain.Stud_Course> stud_Courses { get; set; }
        public DbSet<Domain.Course_Inst> course_Insts { get; set; }


    }
}
