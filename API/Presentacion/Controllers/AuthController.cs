using Datos.DTOs;
using Microsoft.AspNetCore.Mvc;
using Negocio.Contracts;
using Negocio.DataFormatters;

namespace Presentacion.Controllers
{
    [Route("api/auth")]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService; 
        }

        [HttpPost("login")]
        public async Task<IActionResult> authenticateUser([FromBody] UsersAuthDTO user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            MsgServer result = await _authService.authUser(user);
            if (!result.success) return StatusCode(result.status, result.data);
            return Ok(result.data);
        }

        [HttpPost("register")]
        public async Task<IActionResult> registerUser([FromBody] UserCreateDTO user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            MsgServer result = await _authService.createUser(user);
            if (!result.success) return StatusCode(result.status, result.data);
            return Ok(result.data);
        }
    }
}
