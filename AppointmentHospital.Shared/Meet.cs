

using System.ComponentModel.DataAnnotations;

namespace AppointmentHospital.Shared
{
    public class Meet
    {
        [Key]
        public int MeetId { get; set; }

        public int DoctorId { get; set; }
        public int? UserId { get; set; }
        public DateTime CreatedMeet { get; set; } = DateTime.UtcNow;

        public string? DoctorName { get; set; }
        public string? PoliclinicName { get; set; }
        public DateTime MeetDate { get; set; }

        [Required(ErrorMessage ="Lütfen Saat Giriniz")]
        public TimeSpan MeetTime { get; set; }

        public bool Status { get; set; } = true;
    }
}
