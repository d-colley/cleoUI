using CleoUI.Models;
using Microsoft.EntityFrameworkCore;

namespace CleoUI
{
    public class CleoUIDbContext : DbContext
    {
        public CleoUIDbContext(DbContextOptions<CleoUIDbContext> options) : base(options) { }

        public DbSet<Instrument>? Instruments { get; set; }
        public DbSet<InstrumentResult>? InstrumentResults { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
