﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMain.Models
{
    public class Login
    {
        [Key]
        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage = "Bạn phải nhập tài khoản")]
        public string UserName { set; get; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Bạn phải nhập mật khẩu")]
        public string Password { set; get; }

    }
}