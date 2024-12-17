using AppointmentHospital.Api.Services.ForDoctor;
using AppointmentHospital.Shared.Model.DoctorDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentHospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _doctorService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByDoctor([FromRoute]int id)
        {
            return Ok(await _doctorService.GetByDoctor(id));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("addDoctor")]
        public async Task<IActionResult> CreateDoctor(DoctorDto doctor)
        {
            return Ok(await _doctorService.AddDoctor(doctor));
        }
    }
}
