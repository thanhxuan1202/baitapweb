using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day09.Migrations
{
    /// <inheritdoc />
    public partial class InitialBaseline : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "KHACH_HANG",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MaKhachHang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        HoTenKhachHang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        MatKhau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        DienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        NgayDangKy = table.Column<DateOnly>(type: "date", nullable: true),
            //        TrangThai = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__KHACH_HA__3214EC279ECE5945", x => x.ID);
            //        table.UniqueConstraint("AK_KHACH_HANG_MaKhachHang", x => x.MaKhachHang);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "KhuyenMai",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        TenKhuyenMai = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        MucGiamGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
            //        TrangThai = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_KhuyenMai", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LOAI_SAN_PHAM",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MaLoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        TenLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        TrangThai = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__LOAI_SAN__3214EC272E61B888", x => x.ID);
            //        table.UniqueConstraint("AK_LOAI_SAN_PHAM_MaLoai", x => x.MaLoai);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "QUAN_TRI",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        TaiKhoan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        MatKhau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        TrangThai = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__QUAN_TRI__3214EC27D413CDDE", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "HOA_DON",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MaHoaDon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        MaKhachHang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        NgayHoaDon = table.Column<DateOnly>(type: "date", nullable: true, defaultValueSql: "(getdate())"),
            //        NgayNhan = table.Column<DateOnly>(type: "date", nullable: true),
            //        HoTenKhachHang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        DienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        TongTriGia = table.Column<decimal>(type: "decimal(18,2)", nullable: true, defaultValue: 0m),
            //        TrangThai = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__HOA_DON__3214EC2737E8B94F", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK__HOA_DON__MaKhach__4CA06362",
            //            column: x => x.MaKhachHang,
            //            principalTable: "KHACH_HANG",
            //            principalColumn: "MaKhachHang");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SAN_PHAM",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MaSanPham = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        TenSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        HinhAnh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        SoLuong = table.Column<int>(type: "int", nullable: true),
            //        DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        MaLoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        TrangThai = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__SAN_PHAM__3214EC27BE7C9532", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK__SAN_PHAM__MaLoai__45F365D3",
            //            column: x => x.MaLoai,
            //            principalTable: "LOAI_SAN_PHAM",
            //            principalColumn: "MaLoai");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CT_HOA_DON",
            //    columns: table => new
            //    {
            //        ID = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        HoaDonID = table.Column<int>(type: "int", nullable: true),
            //        SanPhamID = table.Column<int>(type: "int", nullable: true),
            //        SoLuongMua = table.Column<int>(type: "int", nullable: true),
            //        DonGiaMua = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
            //        ThanhTien = table.Column<decimal>(type: "decimal(29,2)", nullable: true, computedColumnSql: "([SoLuongMua]*[DonGiaMua])", stored: true),
            //        TrangThai = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__CT_HOA_D__3214EC27E07A56C2", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK__CT_HOA_DO__HoaDo__52593CB8",
            //            column: x => x.HoaDonID,
            //            principalTable: "HOA_DON",
            //            principalColumn: "ID");
            //        table.ForeignKey(
            //            name: "FK__CT_HOA_DO__SanPh__534D60F1",
            //            column: x => x.SanPhamID,
            //            principalTable: "SAN_PHAM",
            //            principalColumn: "ID");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_CT_HOA_DON_HoaDonID",
            //    table: "CT_HOA_DON",
            //    column: "HoaDonID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CT_HOA_DON_SanPhamID",
            //    table: "CT_HOA_DON",
            //    column: "SanPhamID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_HOA_DON_MaKhachHang",
            //    table: "HOA_DON",
            //    column: "MaKhachHang");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__HOA_DON__835ED13A44BA906A",
            //    table: "HOA_DON",
            //    column: "MaHoaDon",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__KHACH_HA__88D2F0E4470B07AC",
            //    table: "KHACH_HANG",
            //    column: "MaKhachHang",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__LOAI_SAN__730A575879FF3C11",
            //    table: "LOAI_SAN_PHAM",
            //    column: "MaLoai",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_SAN_PHAM_MaLoai",
            //    table: "SAN_PHAM",
            //    column: "MaLoai");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__SAN_PHAM__FAC7442C2365E8E6",
            //    table: "SAN_PHAM",
            //    column: "MaSanPham",
            //    unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "CT_HOA_DON");

            //migrationBuilder.DropTable(
            //    name: "KhuyenMai");

            //migrationBuilder.DropTable(
            //    name: "QUAN_TRI");

            //migrationBuilder.DropTable(
            //    name: "HOA_DON");

            //migrationBuilder.DropTable(
            //    name: "SAN_PHAM");

            //migrationBuilder.DropTable(
            //    name: "KHACH_HANG");

            //migrationBuilder.DropTable(
            //    name: "LOAI_SAN_PHAM");
        }
    }
}
