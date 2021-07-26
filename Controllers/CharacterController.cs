using System.Collections.Generic;
using System.Threading.Tasks;
using Dotnet_rpg.Dtos;
using Dotnet_rpg.Models;
using Dotnet_rpg.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _charcaters;
        public CharacterController(ICharacterService charcaters)
        {
            _charcaters = charcaters;

        }

        [HttpGet("GetCharacters")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> GetAllCharacters()
        {
            return Ok(await _charcaters.GetAllCharacters());   
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetCharacterById(int id)
        {
            return Ok(await _charcaters.GetCharacterById(id));
        }

        [HttpPost("AddCharacter")]

        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _charcaters.AddCharacter(newCharacter));
        }

        [HttpPut("UpdateCharacter")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            var response = await _charcaters.UpdateCharacter(updatedCharacter);
            if(response.Data == null)
            {
                return NotFound(response);
            }
            else
            {
                return Ok(response);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> DeleteCharacter(int id)
        {
            var response = await _charcaters.DeleteCharacter(id);
            if(response.Data == null)
            {
                return NotFound(response);
            }
            else
            {
                return Ok(response);
            }
        }
    }
}