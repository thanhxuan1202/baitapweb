using System.ComponentModel.DataAnnotations;

namespace Day12Lab1.Models
{
    public class Student
    {
        public int Id { get; set; }               // Mã sinh viên
        [Required]
        public string? Name { get; set; }         // Họ tên
        [Required(ErrorMessage ="Email bắt buộc phải được nhập")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email không đúng định dạng")]
        public string? Email { get; set; }        // Email
        [StringLength(100, MinimumLength = 8)]
        [Required]
        public string? Password { get; set; }     // Mật khẩu
        [Required]
        public Branch? Branch { get; set; }       // Ngành học
        [Required]
        public Gender? Gender { get; set; }       // Giới tính
        public bool IsRegular { get; set; }       // Hệ: true - chính quy, false - phi chính quy
        [DataType(DataType.MultilineText)]
        [Required]
        public string? Address { get; set; }      // Địa chỉ
        [Range(typeof(DateTime), "1/1/1900", "12/31/2023", ErrorMessage = "Ngày sinh không hợp lệ")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBorth { get; set; } // Ngày sinh
        public string? Avatar { get; set; }
    }
}
