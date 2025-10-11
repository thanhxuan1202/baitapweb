using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day09.Models
{
    [Table(name:"KhuyenMai")]
    public class KhuyenMai
    {
        [Key]
        public int Id { get; set; }
        public string TenKhuyenMai { get; set; } = null!;
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal MucGiamGia { get; set; }
        public bool TrangThai { get; set; }
    }
}
