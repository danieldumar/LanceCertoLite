using Microsoft.EntityFrameworkCore;
using LanceCertoLite.Models;

namespace LanceCertoLite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Leilao> Leiloes { get; set; }
    }
}

