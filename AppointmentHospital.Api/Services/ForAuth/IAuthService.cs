using AppointmentHospital.Shared.ApiResponse;
using AppointmentHospital.Shared;

namespace AppointmentHospital.Api.Services.ForAuth
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string email, string password);

        int GetUserId();
        string GetUserEmail();
    }
}
