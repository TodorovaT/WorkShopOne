using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkShop1.Models;

namespace WorkShop1.Models
{
    public class WorkShop1Context : DbContext
    {
        public WorkShop1Context (DbContextOptions<WorkShop1Context> options)
            : base(options)
        {
        }

        public DbSet<WorkShop1.Models.Course> Course { get; set; }

        public DbSet<WorkShop1.Models.Student> Student { get; set; }

        public DbSet<WorkShop1.Models.Teacher> Teacher { get; set; }

        public DbSet<WorkShop1.Models.Enrollment> Enrollment { get; set; }

        protected override void OnModelCreating (ModelBuilder builder)
        {
            builder.Entity<Enrollment>()
                .HasOne<Student>(p => p.Student)
                .WithMany(p => p.Enrollments)
                .HasForeignKey(p => p.StudentId);

            builder.Entity<Enrollment>()
                .HasOne<Course>(p => p.Course)
                .WithMany(p => p.Enrollments)
                .HasForeignKey(p => p.CourseId);

            builder.Entity<Course>()
                .HasOne<Teacher>(p => p.FirstTeacher)
                .WithMany(p => p.FirstCourses)
                .HasForeignKey(p => p.FirstTeacherId);

            builder.Entity<Course>()
                .HasOne<Teacher>(p => p.SecondTeacher)
                .WithMany(p => p.SecondCourses)
                .HasForeignKey(p => p.SecondTeacherId);

        }
    }
}
