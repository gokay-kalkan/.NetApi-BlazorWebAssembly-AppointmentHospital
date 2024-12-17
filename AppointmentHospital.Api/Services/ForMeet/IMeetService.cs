using AppointmentHospital.Shared.ApiResponse;
using AppointmentHospital.Shared;
using AppointmentHospital.Shared.Model.MeetDtos;

namespace AppointmentHospital.Api.Services.ForMeet
{
    public interface IMeetService
    {
        Task<ServiceResponse<Meet>> CreateMeet(Meet meet);
        Task<ServiceResponse<Meet>> CancelMeet(int id);
        Task<ServiceResponse<List<Meet>>> GetMeetById();
        Task<ServiceResponse<List<DateStatus>>> GetDateStatus(int doctorId);
    }
}
