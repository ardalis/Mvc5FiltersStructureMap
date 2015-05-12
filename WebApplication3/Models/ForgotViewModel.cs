﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}