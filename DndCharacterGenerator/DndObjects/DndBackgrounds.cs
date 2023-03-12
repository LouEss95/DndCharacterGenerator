using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterGenerator.DndObjects
{
    public class DndBackgrounds
    {

        public string? BackgroundName { get; set; }
        public string? BackgroundSkillProf { get; set; }
        public string? BackgroundEquip { get; set; }
        public List<string>? BackgroundPersonalities { get; set; }
        public List<string>? BackgroundIdeals { get; set; }
        public List<string>? BackgroundBonds { get; set; }
        public List<string>? BackgroundFlaws { get; set; }
    }
}
