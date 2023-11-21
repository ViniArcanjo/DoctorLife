using DoctorLife.BLL.Interface;
using DoctorLife.DL.DTO.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorLife.API.Controller
{
    [ApiController]
    [Route("api/v1/doctorlife/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly ILoginService _loginService;

        public LoginController(ITokenService tokenService, ILoginService loginService)
        {
            _tokenService = tokenService;
            _loginService = loginService;
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public async Task<ActionResult<object>> AuthenticateAsync([FromBody] LoginRequest request)
        {
            var user = _loginService.ValidateUser(request);

            if (user == null)
            {
                return NotFound(new { Message = "Invalid email, password or user role. Please, try again." });
            }

            var token = _tokenService.GenerateToken(request);

            return Ok(new { User = user, Token = token });
        }
    }
}
