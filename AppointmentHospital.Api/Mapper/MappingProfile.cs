using AppointmentHospital.Shared;
using AppointmentHospital.Shared.Model.DoctorDtos;
using AutoMapper;

namespace AppointmentHospital.Api.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Doctor, DoctorDto>().ReverseMap();
           
        }
    }
}
