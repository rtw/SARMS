using System.Data.Entity;
using Sarms.Domain.Core;

namespace Sarms.Domain.Data
{
    public class SarmsContext : DbContext
    {
        public DbSet<Assignment> Assignments { get; set;}
        public DbSet<Course> Courses { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Unit> Units { get; set; }

        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
