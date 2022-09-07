using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnotation.Models
{
    public class UserModel
    {
        [Display(Name = "So ID")]
        [Required(ErrorMessage = "Vui long nhap stt")]
        public int Id { get; set; }

        [Display(Name = "Ten")]
        [Required(ErrorMessage = "Vui long nhap ten")]
        [StringLength(50,MinimumLength = 6, ErrorMessage = "Do dai trong khoang tu 6 - 50 ky tu")]
        public String Name { get; set; }

        [Display(Name = "Mat khau")]
        [Required(ErrorMessage = "Nhap mat khau")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Do dai trong khoang tu 5 - 50 ky tu")]
        //[ScaffoldColumn(false)]
        public String Password { get; set; }

        [Display(Name = "Xac nhan mat khau")]
        [Required(ErrorMessage = "Nhap mat khau xac nhan")]
        [Compare("Password", ErrorMessage = "Mat khau khong khop")]
        [DataType(DataType.Password)]
        //[ScaffoldColumn(false)]
        public String ConfirmPassword { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Nhap email")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
    }
}