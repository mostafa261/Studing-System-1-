using Microsoft.EntityFrameworkCore;
using Student_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Student_System.data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }

        public DbSet<StudentCourse> studentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(e => e.Homeworks)
                .WithOne(e => e.student)
                .HasForeignKey(e => e.StudentId)
                .IsRequired(false);

            modelBuilder.Entity<Course>()
              .HasMany(e => e.Homeworks)
              .WithOne(e => e.course)
              .HasForeignKey(e => e.CourseId)
              .IsRequired();

            modelBuilder.Entity<Course>()
            .HasMany(e => e.Resources)
            .WithOne(e => e.course)
            .HasForeignKey(e => e.CourseId)
            .IsRequired();

            modelBuilder.Entity<Student>()
            .HasMany(e => e.Courses)
            .WithMany(e => e.Students)
            .UsingEntity<StudentCourse>();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentSystem;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}