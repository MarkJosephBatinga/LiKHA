﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likha.Shared
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [MinLength(8, ErrorMessage = "8 Minimum Characters Required")]
        public string Password { get; set; }
    }
}
