using AppointmentHospital.Shared;
using AppointmentHospital.Shared.ApiResponse;
using AppointmentHospital.Shared.Model.MeetDtos;

namespace AppointmentHospital.Client.Services.ForMeet
{
    public interface IMeetService
    {
        List<Meet> Meets { get; set; }
        Task<ServiceResponse<List<Meet>>> GetMeet();
        Task<ServiceResponse<Meet>> CreateMeet(Meet meet);
        Task<ServiceResponse<Meet>> CancelMeet(int id);
        Task<ServiceResponse<List<DateStatus>>> GetDateStatus(int doctorId);
    }
}
