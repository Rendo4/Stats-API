using Microsoft.EntityFrameworkCore;

namespace Stats.Models
{
    public class StatsContext : DbContext
    {
        public StatsContext(DbContextOptions<StatsContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
    }
}