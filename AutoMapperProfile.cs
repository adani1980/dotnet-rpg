using AutoMapper;
using Dotnet_rpg.Dtos;
using Dotnet_rpg.Models;

namespace Dotnet_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }   
    }
}