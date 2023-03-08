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
            var bard = new DndClass("Bard", new string[] { "College of Creation", "College of Eloquence", "College of Glamour","College of Lore", "College of Spirits", "College of Swords", "College of Valor", "College of Whispers"});
            var cleric = new DndClass("Cleric", new string[] { "Arcana Domain", "Death Domain", "Forge Domain", "Grave Domain", "Knowledge Domain", "Life Domain","Light Domain", "Nature Domain", "Order Domain", "Peace Domain", "Tempest Domain", "Trickery Domain", "Twilight Domain", "War Domain" });
            var druid = new DndClass("Druid", new string[] { "Circle of Dreams", "Circle of Spores", "Circle of Stars", "Circle of Wildfire", "Circle of the Land", "Circle of the Moon", "Circle of the Shepherd" });
            var fighter = new DndClass("Fighter", new string[] { "Arcane Archer", "Battle Master", "Cavalier", "Champion", "Echo Knight", "Eldritch Knight", "Psi Warrior", "Banneret", "Rune Knight", "Samurai" });
            var monk = new DndClass("Monk", new string[] { "Way of Mercy", "Way of Shadows","Way of the Ascendant Dragon", "Way of the Astral Self", "Way of the Drunken Master","Way of the Four Elements", "Way of the Kensei", "Way of the Long Death","Way of the Sun Soul"  });
            var paladin = new DndClass("Paladin", new string[] { "Oath of Conquest", "Oath of Devotion", "Oath of Glory", "Oath of Redemption", "Oath of the Ancients", "Oath of the Crown", "Oath of the Watchers", "Oath of Vengeance" });
            var ranger = new DndClass("Ranger", new string[] { "Beast Master", "Drakewarden", "Fey Wanderer", "Gloom Stalker", "Horizon Walker", "Hunter", "Monster Slayer", "Swarmkeeper", "" });
            var rogue = new DndClass("Rogue", new string[] { "Arcane Trickster", "Assassin", "Phantom", "Mastermind", "Scout", "Soulknife", "Swashbuckler", "Thief" });
            var sorceror = new DndClass("Sorceror", new string[] { "Aberrant Mind", "Clockwork Soul", "Divine Soul", "Draconic Bloodline", "Lunar Sorcery", "Shadow Magic", "Storm Sorcery", "Wild Magic" });
            var warlock = new DndClass("Warlock", new string[] { "Patron of the Archfey", "Patron of the Celestial", "Patron of the Fathomless", "Patron of the Fiend", "Patron of the Genie", "Patron of the Great Old One", "Patron of the Hexblade", "Patron of the Undead", "Patron of the Undying" });
            var wizard = new DndClass("Wizard", new string[] { "Bladesinger", "Chronurgy Magic", "Graviturgy Magic", "Order of Scribes", "School of Abjuration", "School of Conjuration", "School of Divination", "School of Enchantment", "School of Evocation", "School of Illusion", "School of Necromancy", "School of Transmutation", "War Magic" });
            var bloodHunter = new DndClass("Blood Hunter", new string[] { "Order of The Ghostslayer", "Order of the Lycan", "Order of the Mutant", "Order of the Profane Soul" });
            var artificer = new DndClass("Artificer", new string[] { "Alchemist", "Armorer", "Artillerist", "Battle Smith" });
            var typeClass = new DndClass[] { barbarian, bard, cleric, druid, fighter, monk, paladin, ranger, rogue, sorceror, warlock, wizard, bloodHunter, artificer};
            return typeClass;
        }
        public static DndRace[] GetTypeRace()
        {

            var dragonborn = new DndRace("Dragonborn", new string[] { "Black ", "Blue ", "Green ", "Red ", "White ", "Brass ", "Bronze ", "Copper ", "Gold ", "Silver ", "Amethyst ", "Crystal ", "Emerald ", "Sapphire ", "Topaz "});
            var aarakocran = new DndRace("Aarakocran", Array.Empty<string>());
            var aasimar = new DndRace("Aasimar", new string[] { "Fallen ", "Protector ", "Scourge "});
            var bugbear = new DndRace("Bugbear", Array.Empty<string>());
            var centaur = new DndRace("Centaur", Array.Empty<string>());
            var changeling = new DndRace("Changeling", Array.Empty<string>());
            var typeRace = new DndRace[] {dragonborn, aarakocran, aasimar, bugbear, centaur, changeling  };
            return typeRace;
        }
    }
    
        
}
