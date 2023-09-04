using Microsoft.EntityFrameworkCore;

namespace SchoolSchedulingSystem.Models
{
    public class ScheduleDbContext : DbContext
    {
        public ScheduleDbContext(DbContextOptions<ScheduleDbContext> options):base(options) 
        {
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
