using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CaoThiThanhXuan_231230966_de01.Models;

public partial class CaoThiThanhXuan231230966De01Context : DbContext
{
    public CaoThiThanhXuan231230966De01Context()
    {
    }

    public CaoThiThanhXuan231230966De01Context(DbContextOptions<CaoThiThanhXuan231230966De01Context> options)
        : base(options)
    {
    }

    public virtual DbSet<CaoThiThanhXuanComputer> CaoThiThanhXuanComputers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ADMIN-PC\\XUAN;Database=CaoThiThanhXuan_231230966_de01;uid=sa;pwd=1234$;MultipleActiveResultSets=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CaoThiThanhXuanComputer>(entity =>
        {
            entity.HasKey(e => e.CaoThiThanhXuanComId).HasName("PK__CaoThiTh__1B2EDF6E3FBB4958");

            entity.ToTable("CaoThiThanhXuanComputer");

            entity.Property(e => e.CaoThiThanhXuanComImage).HasMaxLength(200);
            entity.Property(e => e.CaoThiThanhXuanComName).HasMaxLength(100);
            entity.Property(e => e.CaoThiThanhXuanComPrice).HasColumnType("decimal(12, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
