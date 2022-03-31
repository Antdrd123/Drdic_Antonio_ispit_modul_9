using Microsoft.EntityFrameworkCore;
using EF_CodeFirst.Models;

namespace EF_CodeFirst.Database
{
    public class StudentContext :DbContext
    {
       public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentID = 1,
                    StudentName = "Marko",
                    DateOfBirth = new DateTime (1998,7,8),
                    Height = 187,
                    Weight = 85
                },
                new Student
                {
                    StudentID = 2,
                    StudentName = "Ana",
                    DateOfBirth = new DateTime(1994, 5, 2),
                    Height = 168,
                    Weight = 57
                }

                );

            modelBuilder.Entity<Grade>().HasData(
                new Grade
                {
                    GradeID = 1,
                    GradeName = "Excellent",
                    Section = "Biology",
                    StudentId = 1
                },
                new Grade
                {
                    GradeID = 2,
                    GradeName = "Very good",
                    Section = "Biology",
                    StudentId = 1
                },
                new Grade
                {
                       GradeID = 3,
                       GradeName = "Good",
                       Section = "Chemistry",
                       StudentId = 1
                },
                new Grade
                {
                    GradeID = 4,
                    GradeName = "Enough",
                    Section = "English",
                    StudentId = 1
                },
                new Grade
                {
                    GradeID = 5,
                    GradeName = "Excellent",
                    Section = "Geography",
                    StudentId = 2
                },
                new Grade
                {
                    GradeID = 6,
                    GradeName = "Very good",
                    Section = "Latin",
                    StudentId = 2
                },
                new Grade
                {
                    GradeID = 7,
                    GradeName = "Bad",
                    Section = "Mathematics",
                    StudentId = 2
                }

                );
        }


    }
}
