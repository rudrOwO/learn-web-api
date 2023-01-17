using Microsoft.EntityFrameworkCore;
using MiniFB.Core.Models;
using MiniFB.Core.Options;

namespace MiniFB.Core.Db;

public partial class MiniFbContext : DbContext
{
    private readonly DatabaseOptions _databaseOptions;

    public MiniFbContext()
    {
        this._databaseOptions = new DatabaseOptions();
    }

    public MiniFbContext(DbContextOptions<MiniFbContext> options)
        : base(options)
    {
        this._databaseOptions = new DatabaseOptions();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=Data/MiniFB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<Status>? Statuses { get; set; }
}
