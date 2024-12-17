using AppointmentHospital.Shared.ApiResponse;
using AppointmentHospital.Shared.Model.DoctorDtos;
using AppointmentHospital.Shared;

namespace AppointmentHospital.Api.Services.ForDoctor
{
    public interface IDoctorService
    {
        Task<ServiceResponse<List<Doctor>>> GetAll();
        Task<ServiceResponse<List<Doctor>>> GetByDoctor(int policlinicId);
        Task<ServiceResponse<DoctorDto>> AddDoctor(DoctorDto doctor);
    }
}
