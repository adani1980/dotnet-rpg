using System.Collections.Generic;
using System.Threading.Tasks;
using Dotnet_rpg.Dtos.Fight;
using Dotnet_rpg.Models;

namespace Dotnet_rpg.Services.Fights
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
        Task<ServiceResponse<List<HighscoreDto>>> GetHighscore();
    }
}