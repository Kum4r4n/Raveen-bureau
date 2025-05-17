using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using raveenbureau.API.Models;
using raveenbureau.API.Services;

namespace raveenbureau.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            var data = await _authService.Login(loginModel);
            data.PasswordHash = "";
            return Ok(data);
        }
    }
}
