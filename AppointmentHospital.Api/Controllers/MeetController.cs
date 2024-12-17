using AppointmentHospital.Api.Services.ForMeet;
using AppointmentHospital.Shared.ApiResponse;
using AppointmentHospital.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppointmentHospital.Shared.Model.MeetDtos;

namespace AppointmentHospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetController : ControllerBase
    {
        private readonly IMeetService _meetService;
        public MeetController(IMeetService meetService)
        {
            _meetService = meetService;
        }

        [HttpPost("createMeet"), Authorize]
        public async Task<IActionResult> CreateMeet(Meet meet)
        {
            var result = await _meetService.CreateMeet(meet);
            return Ok(result);
        }

        [HttpPut("cancelMeet/{meetId}"), Authorize]
        public async Task<IActionResult> CancelMeet([FromRoute] int meetId)
        {
            var result = await _meetService.CancelMeet(meetId);
            return Ok(result);
        }

        [HttpGet, Authorize]
        public async Task<IActionResult> GetMyMeet()
        {
            var result = await _meetService.GetMeetById();
            return Ok(result);
        }

        [HttpGet("GetDateStatus/{doctorId}")]
        public async Task<ServiceResponse<List<DateStatus>>> GetDateStatus(int doctorId)
        {
            return await _meetService.GetDateStatus(doctorId);
        }

    }
}
