//using BCS.JobProcessing.Host.Models;
//using Microsoft.EntityFrameworkCore;

//public partial class OdsContext : DbContext
//{
//    public OdsContext()
//    {
//    }

//    public OdsContext(DbContextOptions<OdsContext> options)
//        : base(options)
//    {
//    }

//    public virtual DbSet<GrossPremiumDTO> GrossPremiumDTO { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        if (!optionsBuilder.IsConfigured)
//        {
//            optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
//        }
//    }

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.HasDefaultSchema("BCS\\rxs0002");
//        modelBuilder.HasSequence("ODS_SequenceNumber", "OPS").StartsAt(-1000000000L);

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}