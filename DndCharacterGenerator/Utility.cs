using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterGenerator
{
    public static class Utility
    {
        public static DndClass[] GetTypeClasses()
        {
            var barbarian = new DndClass("Barbarian", new string[] { "Path of the Ancestral Guardian", "Path of the Battlerager", "Path of the Beast", "Path of the Beserker","Path of the Storm Herald", "Path of the Totem Warrior","Path of the Zealot", "Path of Wild Magic" });
            var bard = new DndClass("Bard", new string[] { "College of Creation", "College of Eloquence", "College of Glamour" });
            var cleric = new DndClass("Cleric", new string[] { "Arcana Domain", "Death Domain", "Forge Domain" });
            var typeClass = new DndClass[] { barbarian, bard, cleric };
            return typeClass;
        }
    }
}
