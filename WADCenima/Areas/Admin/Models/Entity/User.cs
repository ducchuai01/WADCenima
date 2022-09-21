using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WADCenima.Areas.Admin.Models.Entity;

namespace WADCenima.Areas.Admin.Models
{
    [Table("User")]
    public class User
    {
        [DisplayName("Mã người dùng")]
        public Guid UserId { get; set; }
        [DisplayName("Tên đầy đủ")]
        [StringLength(100)]
        public string FullName { get; set; }
        [DisplayName("Giới tính")]
        public Boolean Gender { get; set; }
        [DisplayName("Số căn cước công dân")]
        public int IdentityCard { get; set; }
        [DisplayName("Địa chỉ email")]
        [MaxLength()]
        public string Email { get; set; }
        [DisplayName("Ngày sinh")]
        public DateTime BirthDay { get; set; }
        [DisplayName("Số điện thoại")]
        [StringLength(10)]
        public string Phone { get; set; }
        [DisplayName("Tên đăng nhập")]
        [StringLength(100)]
        public string UserName { get; set; }
        [DisplayName("Mật khẩu")]
        [MaxLength()]
        public string Password { get; set; }
        public int RoleId { get; set; }

        public Role role { get; set; }
    }
}
