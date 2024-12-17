using AppointmentHospital.Api.Services.ForAuth;
using AppointmentHospital.Shared.ApiResponse;
using AppointmentHospital.Shared.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentHospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AccountController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> CreateRegister(UserRegister user)
        {
            var result = await _authService.Register(new Shared.User
            {
                Email = user.Email
            }, user.Password);
            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLogin user)
        {
            var result = await _authService.Login(user.Email, user.Password);
            if (result == null)
            {
                return BadRequest("User is not found");
            }
            return Ok(result);
        }
    }
}
