

using System.ComponentModel.DataAnnotations;

namespace AppointmentHospital.Shared
{
    public class Policlinic
    {
        [Key]
        public int PoliclinicId { get; set; }
        public string PoliclinicName { get; set; }
        
    }
}
