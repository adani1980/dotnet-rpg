using System.Collections.Generic;
using Dotnet_rpg.Dtos.Car;
using Dotnet_rpg.Dtos.Skill;
using Dotnet_rpg.Dtos.Weapon;
using Dotnet_rpg.Models;

namespace Dotnet_rpg.Dtos
{
    public class GetCharacterDto
    {
        public int Id { get; set; } 
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knigth;
        public GetWeaponDto Weapon { get; set; }
        public List<GetSkillDto> Skills { get; set; }
        public List<GetCarDto> Cars { get; set; }
        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}