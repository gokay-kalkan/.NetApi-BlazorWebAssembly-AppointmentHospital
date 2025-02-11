﻿

using System.ComponentModel.DataAnnotations;

namespace AppointmentHospital.Shared.Model
{
    public class UserRegister
    {
        [Required(ErrorMessage = "Email alanı gereklidir"), EmailAddress]
        public string Email { get; set; }
        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "pasword do not match")]
        public string ConfirmPassword { get; set; }
    }
}
