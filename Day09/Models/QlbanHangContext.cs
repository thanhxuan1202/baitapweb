using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Day09.Models;

public partial class QlbanHangContext : DbContext
{
    public QlbanHangContext()
    {
    }

    public QlbanHangContext(DbContextOptions<QlbanHangContext> options)
        : base(options)
    {
    }
    public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }

    public virtual DbSet<CtHoaDon> CtHoaDons { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }

    public virtual DbSet<QuanTri> QuanTris { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ADMIN-PC\\XUAN;Database=QLBanHang;uid=sa;pwd=1234$; MultipleActiveResultSets=True; TrustServerCertificate=True ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CtHoaDon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CT_HOA_D__3214EC27E07A56C2");

            entity.ToTable("CT_HOA_DON");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DonGiaMua).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HoaDonId).HasColumnName("HoaDonID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.ThanhTien)
                .HasComputedColumnSql("([SoLuongMua]*[DonGiaMua])", true)
                .HasColumnType("decimal(29, 2)");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);

            entity.HasOne(d => d.HoaDon).WithMany(p => p.CtHoaDons)
                .HasForeignKey(d => d.HoaDonId)
                .HasConstraintName("FK__CT_HOA_DO__HoaDo__52593CB8");

            entity.HasOne(d => d.SanPham).WithMany(p => p.CtHoaDons)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__CT_HOA_DO__SanPh__534D60F1");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HOA_DON__3214EC2737E8B94F");

            entity.ToTable("HOA_DON");

            entity.HasIndex(e => e.MaHoaDon, "UQ__HOA_DON__835ED13A44BA906A").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi).HasMaxLength(200);
            entity.Property(e => e.DienThoai).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.HoTenKhachHang).HasMaxLength(100);
            entity.Property(e => e.MaHoaDon).HasMaxLength(20);
            entity.Property(e => e.MaKhachHang).HasMaxLength(20);
            entity.Property(e => e.NgayHoaDon).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.TongTriGia)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.HoaDons)
                .HasPrincipalKey(p => p.MaKhachHang)
                .HasForeignKey(d => d.MaKhachHang)
                .HasConstraintName("FK__HOA_DON__MaKhach__4CA06362");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__KHACH_HA__3214EC279ECE5945");

            entity.ToTable("KHACH_HANG");

            entity.HasIndex(e => e.MaKhachHang, "UQ__KHACH_HA__88D2F0E4470B07AC").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi).HasMaxLength(200);
            entity.Property(e => e.DienThoai).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.HoTenKhachHang).HasMaxLength(100);
            entity.Property(e => e.MaKhachHang).HasMaxLength(20);
            entity.Property(e => e.MatKhau).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<LoaiSanPham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOAI_SAN__3214EC272E61B888");

            entity.ToTable("LOAI_SAN_PHAM");

            entity.HasIndex(e => e.MaLoai, "UQ__LOAI_SAN__730A575879FF3C11").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaLoai).HasMaxLength(20);
            entity.Property(e => e.TenLoai).HasMaxLength(100);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<QuanTri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QUAN_TRI__3214EC27D413CDDE");

            entity.ToTable("QUAN_TRI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MatKhau).HasMaxLength(50);
            entity.Property(e => e.TaiKhoan).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SAN_PHAM__3214EC27BE7C9532");

            entity.ToTable("SAN_PHAM");

            entity.HasIndex(e => e.MaSanPham, "UQ__SAN_PHAM__FAC7442C2365E8E6").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HinhAnh).HasMaxLength(255);
            entity.Property(e => e.MaLoai).HasMaxLength(20);
            entity.Property(e => e.MaSanPham).HasMaxLength(20);
            entity.Property(e => e.TenSanPham).HasMaxLength(100);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);

            entity.HasOne(d => d.MaLoaiNavigation).WithMany(p => p.SanPhams)
                .HasPrincipalKey(p => p.MaLoai)
                .HasForeignKey(d => d.MaLoai)
                .HasConstraintName("FK__SAN_PHAM__MaLoai__45F365D3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
