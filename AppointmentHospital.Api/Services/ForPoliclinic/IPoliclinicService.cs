
using AppointmentHospital.Shared.ApiResponse;
using AppointmentHospital.Shared;

namespace AppointmentHospital.Api.Services.ForPoliclinic
{
    public interface IPoliclinicService
    {
        Task<ServiceResponse<Policlinic>> AddPoly(Policlinic policlinic);
        Task<ServiceResponse<List<Policlinic>>> GetAll();
        Task<ServiceResponse<Policlinic>> UpdatePoly(Policlinic policlinic);
        Task<ServiceResponse<int>> DeletePoly(int poliId);
        Task<ServiceResponse<Policlinic>> GetById(int policid);
    }
}
