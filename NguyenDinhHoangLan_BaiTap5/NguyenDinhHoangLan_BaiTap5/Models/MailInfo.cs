using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenDinhHoangLan_BaiTap5.Models
{
    public class MailInfo
    {
        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [DisplayName("Gửi từ Email")]
        public string From { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [DisplayName("Gửi đến Email")]
        public string To { get; set; }
        [DisplayName("Tiêu đề")]
        public string Subject { get; set; }
        [DisplayName("Nội dung")]
        public string Body { get; set; }
    }
}