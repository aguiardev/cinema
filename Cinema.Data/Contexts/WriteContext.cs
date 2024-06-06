using Cinema.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Data.Contexts;
public class WriteContext : DbContext
{
    public DbSet<Venue> Venues { get; set; }
    
    public WriteContext(DbContextOptions<WriteContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Venue>().ToTable("Venues");

        base.OnModelCreating(builder);
    }
}