using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Plant
{
  public partial class PlantsContext : DbContext
  {
    public DbSet<Plants> Plant { get; set; }
    public PlantsContext()
    {
    }

    public PlantsContext(DbContextOptions<PlantsContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {

        optionsBuilder.UseNpgsql("server=localhost;database=PlantsDb");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}
