using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebsiteVot.Models
{
    [Table("NGUOIDUNG")]
    public partial class Nguoidung
    {
        public Nguoidung()
        {
            Hoadon = new HashSet<Hoadon>();
        }

        [Key]
        [Column("MaND")]
        public int MaNd { get; set; }
        [Required]
        [StringLength(100)]
        public string Ten { get; set; }
        [StringLength(20)]
        public string DienThoai { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(70)]
        public string DiaChi { get; set; }
        [StringLength(255)]
        public string MatKhau { get; set; }
        [StringLength(1)]
        public string PhanQuyen { get; set; }

        [InverseProperty("MaNdNavigation")]
        public virtual ICollection<Hoadon> Hoadon { get; set; }
    }
}
