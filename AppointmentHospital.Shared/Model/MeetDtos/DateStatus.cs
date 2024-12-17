

namespace AppointmentHospital.Shared.Model.MeetDtos
{
    public class DateStatus
    {
        public DateTime Date { get; set; }
        public List<TimeSpan> BusyTimes { get; set; }
        public bool IsFullyBooked { get; set; }
    }
}
