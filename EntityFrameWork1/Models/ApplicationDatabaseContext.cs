using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameWork1.Models;
using CoreTest1000.Models;

namespace EntityFrameWork1.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> Assignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);

            //Many to Many between students and courses
            modelBuilder.Entity<StudentCourse>()
            .HasKey(bc => new { bc.StudentId, bc.CourseId });
            modelBuilder.Entity<StudentCourse>()
                .HasOne(bc => bc.Student)
                .WithMany(b => b.StudentCourses)
                .HasForeignKey(bc => bc.StudentId);
            modelBuilder.Entity<StudentCourse>() 
                .HasOne(bc => bc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(bc => bc.CourseId);

            //Many to Many between students and teachers
            modelBuilder.Entity<StudentTeacher>()
            .HasKey(bc => new { bc.StudentId, bc.TeacherId });
            modelBuilder.Entity<StudentTeacher>()
                .HasOne(bc => bc.Student)
                .WithMany(b => b.StudentTeachers)
                .HasForeignKey(bc => bc.StudentId);
            modelBuilder.Entity<StudentTeacher>()
                .HasOne(bc => bc.Teacher)
                .WithMany(c => c.StudentTeachers)
                .HasForeignKey(bc => bc.TeacherId);

            //Many to Many between Teachers and Courses
            modelBuilder.Entity<TeacherCourse>()
            .HasKey(bc => new { bc.CourseId, bc.TeacherId });
            modelBuilder.Entity<TeacherCourse>()
                .HasOne(bc => bc.Course)
                .WithMany(b => b.TeacherCourses)
                .HasForeignKey(bc => bc.CourseId);
            modelBuilder.Entity<TeacherCourse>()
                .HasOne(bc => bc.Teacher)
                .WithMany(c => c.TeacherCourses)
                .HasForeignKey(bc => bc.TeacherId);
        }
    }
}
