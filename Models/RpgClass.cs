using System.Text.Json.Serialization;

namespace Dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knigth,
        Mage,
        Cleric
    }
}