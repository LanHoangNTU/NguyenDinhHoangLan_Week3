using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenDinhHoangLan_BaiTap3.Models
{
    public class EmpModel
    {
        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [DisplayName("Mã số nhân viên")]
        public string EmpID { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [DisplayName("Họ tên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [DisplayName("Ngày sinh")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [DisplayName("Đơn vị")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống ảnh")]
        [DisplayName("Ảnh đại diện")]
        public string Avatar { get; set; }
    }
}