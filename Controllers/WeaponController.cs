using System.Threading.Tasks;
using Dotnet_rpg.Dtos;
using Dotnet_rpg.Dtos.Weapon;
using Dotnet_rpg.Models;
using Dotnet_rpg.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_rpg.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeaponController : ControllerBase
    {
        private readonly IWeaponService _weaponService;
        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            var response = await _weaponService.AddWeapon(newWeapon);
            if(response == null)
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