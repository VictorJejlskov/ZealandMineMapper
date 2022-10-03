using Microsoft.EntityFrameworkCore;

namespace RestExercise1.Models
{
    public class IPAContext : DbContext
    {
        public IPAContext(DbContextOptions<IPAContext> options) : base(options)
        {

        }
        public DbSet<IPA> IPAs { get; set; }
    }
}
