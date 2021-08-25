using System.Collections.Generic;

namespace Dotnet_rpg.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public List<Character> Characters { get; set; }
    }
}