using Dotnet_rpg.Models;

namespace Dotnet_rpg.Dtos
{
    public class UpdateCharacterDto
    {
        public int Id { get; set; } 
        public string Name { get; set; } = "Cosmin IT";
        public int HitPoints { get; set; } = 200;
        public int Strength { get; set; } = 100;
        public int Defence { get; set; } = 100;
        public int Intelligence { get; set; } = 1000;
        public RpgClass Class { get; set; } = RpgClass.Knigth;
    }
}