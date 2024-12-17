

using System.ComponentModel.DataAnnotations;

namespace AppointmentHospital.Shared
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
      
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public string Role { get; set; } = "Person";
    }
}
