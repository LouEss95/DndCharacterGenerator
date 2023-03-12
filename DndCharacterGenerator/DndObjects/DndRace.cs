using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterGenerator.DndObjects
{
    public class DndRace
    {
        public string? RaceName { get; set; }
        public int MinHeight { get; set; }
        public int MaxHeight { get; set; }
        public int MinWeight { get; set; }
        public int MaxWeight { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public List<DndSubraces>? Subraces { get; set; }
    }
}
