using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Web2_02.Models;


namespace Web2_02.Data
{
    namespace Web2_02.Data
    {
        public class SchoolDbContext : DbContext
        {
            public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
            {
            }

            public DbSet<Students> Students { get; set; }
            public DbSet<Courses> Courses { get; set; }
            public DbSet<StudentCourses> StudentCourses { get; set; }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                builder.Entity<Models.StudentCourses>().HasKey(h => new { h.StudentId, h.CoursesId });

            }
        }

        public class DbInitializer
        {
            public static void Initialize(SchoolDbContext context)
            {
                context.Database.EnsureCreated();

                // Add initial data here
                if (!context.Students.Any())
                {
                    var students = new List<Students>
                {
                    new Students { Name = "John Doe" },
                    new Students { Name = "Jane Smith" }
                    // Add more students as needed
                };
                    context.Students.AddRange(students);
                    context.SaveChanges();
                }

                if (!context.Courses.Any())
                {
                    var courses = new List<Courses>
                {
                    new Courses { CourseName = "Math", Description = "Mathematics course" },
                    new Courses { CourseName = "Science", Description = "Science course" }
                    // Add more courses as needed
                };
                    context.Courses.AddRange(courses);
                    context.SaveChanges();
                }

                // Add more initial data for other entities if needed
            }
        }
    }
}