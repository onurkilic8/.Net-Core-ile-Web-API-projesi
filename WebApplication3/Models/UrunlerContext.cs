using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class UrunlerContext: DbContext
    {
        public UrunlerContext(DbContextOptions<UrunlerContext> options): base(options)
        {

        }

        public DbSet<Urunler> Urunlers { get; set; }
    }
}
