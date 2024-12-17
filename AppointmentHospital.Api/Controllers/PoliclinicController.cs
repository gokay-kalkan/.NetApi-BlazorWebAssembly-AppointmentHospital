using AppointmentHospital.Api.Services.ForPoliclinic;
using AppointmentHospital.Shared.ApiResponse;
using AppointmentHospital.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentHospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliclinicController : ControllerBase
    {
        private readonly IPoliclinicService _policlinicService;
        public PoliclinicController(IPoliclinicService policlinicService)
        {
            _policlinicService = policlinicService;
        }

        [HttpPost("add"), Authorize(Roles = "Admin")]
        public async Task<ActionResult<ServiceResponse<Policlinic>>> CreatePoliclinic(Policlinic policlinic)
        {
            var result = await _policlinicService.AddPoly(policlinic);
            return Ok(result);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetPoliclinics()
        {
            var result = await _policlinicService.GetAll();
            return Ok(result);
        }

        [HttpPut("update"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdatePoliclinic(Policlinic poli)
        {
            var result = await _policlinicService.UpdatePoly(poli);
            return Ok(result);
        }

        [HttpDelete("delete/{poliId}"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletePoly([FromRoute] int poliId)
        {
            var result = await _policlinicService.DeletePoly(poliId);
            return Ok(result);
        }

        [HttpGet("{id}"), Authorize]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var result = await _policlinicService.GetById(id);
            return Ok(result);
        }
    }
}
