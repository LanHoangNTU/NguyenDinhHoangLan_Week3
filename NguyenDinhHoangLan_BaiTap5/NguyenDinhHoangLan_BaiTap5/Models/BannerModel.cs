using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenDinhHoangLan_BaiTap5.Models
{
    public class BannerModel
    {
        [Required(ErrorMessage = "Không được bỏ trống ảnh")]
        [DisplayName("Chọn ảnh làm banner: ")]
        public string banner { get; set; }
    }
}