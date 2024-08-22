using EFCBasic02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCBasic02.contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database : University ; Trusted_Connect : True ; Encrypt = False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                        .HasMany(S => S.studentCourse)
                        .WithOne(SC => SC.student);

            modelBuilder.Entity<Course>()
                        .HasMany(C => C.courseStudent)
                        .WithOne(SC => SC.course);
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Course_Ins> course_Ins { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Stud_Course> Stud_Course { get; set; }
        
        

    }
}
