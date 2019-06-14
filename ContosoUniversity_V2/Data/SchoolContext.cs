using ContosoUniversity_V2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity_V2.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; } //primary key: CourseID
        public DbSet<Enrollment> Enrollments { get; set; } //primary key: EnrollmentID
        //enrollment and courses set are optional because 
        //the Entity Framework implicitly would add them to the 
        //db because the student class navigates to them
        public DbSet<Student> Students { get; set; } //primary key: ID
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<CourseAssignment> CourseAssignments { get; set; }


        //this method names the sql tables in the singular rather than the plural
        //i.e. Course, Student, Enrollment instead of Courses, Students, and Enrollments
        //which EF would do by default because those are the DbSet variable names
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<OfficeAssignment>().ToTable("OfficeAssignment");
            modelBuilder.Entity<CourseAssignment>().ToTable("CourseAssignment");

            modelBuilder.Entity<CourseAssignment>() //configures the CourseAssignments
                                                    //composite primary-key
                .HasKey(c => new { c.CourseID, c.InstructorID});
        }

    }
}
