﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HOSPITALMANAGEMENTSYSTEM.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Username must be required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password must be required")]
        public string Password { get; set; }
    }
}