using System.Threading.Tasks;
using Dotnet_rpg.Data;
using Dotnet_rpg.Dtos.User;
using Dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;
        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;

        }

        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
        {
            var response = await _authRepo.Register(
                new User { Username = request.Username }, request.Password
            );
            
            if(!response.Success)
            {
                return BadRequest(response);
            }
            else
            {
                return Ok(response);
            }

        }

        [HttpPost("Login")]

        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
        {
            var response = await _authRepo.Login(
                request.Username, request.Password
            );

            if(!response.Success)
            {
                return BadRequest(response);
            }
            else
            {
                return Ok(response);
            }
        }

    }
}