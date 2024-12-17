
using System.ComponentModel.DataAnnotations;


namespace AppointmentHospital.Shared.Model
{
    public class UserLogin
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
