using System.Data.Entity;
using Sarms.Domain.Core;

namespace Sarms.Domain.Data
{
    public class SarmsContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Assignment> Assignments { get; set;}
        public DbSet<Course> Courses { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}
