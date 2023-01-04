using Microsoft.EntityFrameworkCore;
using MiniFB.Models;

namespace MiniFB.Core.Db;

public partial class MiniFbContext : DbContext
{
    public MiniFbContext(DbContextOptions<MiniFbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=Data/MiniFB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<IEnumerable<Status>>? AllStatus;
}
