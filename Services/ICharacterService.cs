using System.Collections.Generic;
using System.Threading.Tasks;
using Dotnet_rpg.Dtos;
using Dotnet_rpg.Models;

namespace Dotnet_rpg.Services
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
         Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
         Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
         Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
         Task<ServiceResponse<GetCharacterDto>> AddCharacterCar(AddCharacterCarDto newCharacterCar);
    }
}