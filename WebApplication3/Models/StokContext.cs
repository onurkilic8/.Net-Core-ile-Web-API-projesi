using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class StokContext : DbContext
    {
        public StokContext(DbContextOptions<StokContext> options) : base(options)
        {

        }

        public DbSet<Stok> Stoklar { get; set; }
    }
}
