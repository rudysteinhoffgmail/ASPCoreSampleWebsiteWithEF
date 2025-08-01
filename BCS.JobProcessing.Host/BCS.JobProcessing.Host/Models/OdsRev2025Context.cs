using BCS.JobProcessing.Host.Models;
using Microsoft.EntityFrameworkCore;

public partial class OdsRev2025Context : DbContext
{
    public OdsRev2025Context()
    {
    }

    public OdsRev2025Context(DbContextOptions<OdsRev2025Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ValidateGutOdsPremiumDataDTO> ValidateGutOdsPremiumDataDTO { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("BCS\\rxs0002");
        modelBuilder.HasSequence("ODS_SequenceNumber", "OPS").StartsAt(-1000000000L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}