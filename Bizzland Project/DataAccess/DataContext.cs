using Bizzland_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Bizzland_Project.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Services> Services { get; set; }
        public DbSet<TeamMembers> TeamMembers { get; set; }

    }
}
