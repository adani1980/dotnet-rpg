using AutoMapper;
using Dotnet_rpg.Dtos;
using Dotnet_rpg.Dtos.Car;
using Dotnet_rpg.Dtos.Fight;
using Dotnet_rpg.Dtos.Skill;
using Dotnet_rpg.Dtos.Weapon;
using Dotnet_rpg.Models;

namespace Dotnet_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Car, GetCarDto>();
            CreateMap<Character, HighscoreDto>();
        }   
    }
}