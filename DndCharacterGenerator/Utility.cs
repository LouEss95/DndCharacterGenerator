using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterGenerator
{
    public static class Utility
    {
        public static DndClass[] GetTypeClasses()
        {   //optimise
            var barbarian = new DndClass("Barbarian", new string[] { "Path of the Ancestral Guardian", "Path of the Battlerager", "Path of the Beast", "Path of the Beserker","Path of the Storm Herald", "Path of the Totem Warrior","Path of the Zealot", "Path of Wild Magic" });
            var bard = new DndClass("Bard", new string[] { "College of Creation", "College of Eloquence", "College of Glamour","College of Lore", "College of Spirits", "College of Swords", "College of Valor", "College of Whispers"});
            var cleric = new DndClass("Cleric", new string[] { "Arcana Domain", "Death Domain", "Forge Domain", "Grave Domain", "Knowledge Domain", "Life Domain","Light Domain", "Nature Domain", "Order Domain", "Peace Domain", "Tempest Domain", "Trickery Domain", "Twilight Domain", "War Domain" });
            var druid = new DndClass("Druid", new string[] { "Circle of Dreams", "Circle of Spores", "Circle of Stars", "Circle of Wildfire", "Circle of the Land", "Circle of the Moon", "Circle of the Shepherd" });
            var fighter = new DndClass("Fighter", new string[] { "Arcane Archer", "Battle Master", "Cavalier", "Champion", "Echo Knight", "Eldritch Knight", "Psi Warrior", "Banneret", "Rune Knight", "Samurai" });
            var monk = new DndClass("Monk", new string[] { "Way of Mercy", "Way of Shadows","Way of the Ascendant Dragon", "Way of the Astral Self", "Way of the Drunken Master","Way of the Four Elements", "Way of the Kensei", "Way of the Long Death","Way of the Sun Soul"  });
            var paladin = new DndClass("Paladin", new string[] { "Oath of Conquest", "Oath of Devotion", "Oath of Glory", "Oath of Redemption", "Oath of the Ancients", "Oath of the Crown", "Oath of the Watchers", "Oath of Vengeance" });
            var ranger = new DndClass("Ranger", new string[] { "Beast Master", "Drakewarden", "Fey Wanderer", "Gloom Stalker", "Horizon Walker", "Hunter", "Monster Slayer", "Swarmkeeper" });
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
            //optimise
            var dragonborn = new DndRace("Dragonborn", new string[] { "Black ", "Blue ", "Green ", "Red ", "White ", "Brass ", "Bronze ", "Copper ", "Gold ", "Silver ", "Amethyst ", "Crystal ", "Emerald ", "Sapphire ", "Topaz "});
            var aarakocran = new DndRace("Aarakocran", Array.Empty<string>());
            var aasimar = new DndRace("Aasimar", new string[] { "Fallen ", "Protector ", "Scourge "});
            var bugbear = new DndRace("Bugbear", Array.Empty<string>());
            var centaur = new DndRace("Centaur", Array.Empty<string>());
            var changeling = new DndRace("Changeling", Array.Empty<string>());
            var dwarf = new DndRace("Dwarf", new string[] { "Hill ", "Mountain "});
            var duergar = new DndRace("Duergar", Array.Empty<string>());
            var elf = new DndRace("Elf", new string[] { "High ", "Wood ", "Dark ", "Astral ", "Eladrin ", "Shadar-Kai ", "Sea "});
            var halfElf = new DndRace("Half-Elf", Array.Empty<string>());
            var fairy = new DndRace("Fairy", Array.Empty<string>());
            var firbolg = new DndRace("Firbolg", Array.Empty<string>());
            var genasi = new DndRace("Genasi", new string[] { "Fire ", "Water ", "Earth ", "Air "});
            var githzerai = new DndRace("Githzerai", Array.Empty<string>());
            var githyanki = new DndRace("Githyanki", Array.Empty<string>());
            var gnome = new DndRace("Gnome", new string[] { "Forest ", "Rock "});
            var svirfneblin = new DndRace("Svirfneblin", Array.Empty<string>());
            var goblin = new DndRace("Goblin", Array.Empty<string>());
            var goliath = new DndRace("Goliath", Array.Empty<string>());
            var halfling = new DndRace("Halfling", new string[] { "Lightfoot ", "Stout ", "Ghostwise " });
            var orc = new DndRace("Orc", Array.Empty<string>());
            var halfOrc = new DndRace("Half-Orc", Array.Empty<string>());
            var harengon = new DndRace("Harengon", Array.Empty<string>());
            var hobgoblin = new DndRace("Hobgoblin", Array.Empty<string>());
            var human = new DndRace("Human", Array.Empty<string>());
            var kenkuu = new DndRace("Kenkuu", Array.Empty<string>());
            var kobold = new DndRace("Kobold", Array.Empty<string>());
            var leonin = new DndRace("Leonin", Array.Empty<string>());
            var lizardfolk = new DndRace("Lizardfolk", Array.Empty<string>());
            var minotaur = new DndRace("Minotaur", Array.Empty<string>());
            var locathah = new DndRace("Locathah", Array.Empty<string>());
            var owlin = new DndRace("Owlin", Array.Empty<string>());
            var reborn = new DndRace("Reborn", Array.Empty<string>());
            var satyr = new DndRace("Satyr", Array.Empty<string>());
            var shifter = new DndRace("Shifter", new string[] { "Beasthide ", "Swiftstride ", "Longtooth ", "Wildhunt " });
            var tabaxi = new DndRace("Tabaxi", Array.Empty<string>());
            var tiefling = new DndRace("Tiefling", new string[] { "Asmodeus ", "Baalzebul ", "Dispater ", "Fierna ", "Glasya ", "Levistus ", "Mammon ", "Mephistopheles ", "Zariel " });
            var tortle = new DndRace("Tortle", Array.Empty<string>());
            var triton = new DndRace("Triton", Array.Empty<string>());
            var yuanTi = new DndRace("Yuan-Ti", Array.Empty<string>());
            var typeRace = new DndRace[] {dragonborn, aarakocran, aasimar, bugbear, centaur, changeling, dwarf, duergar, elf, halfElf, fairy, firbolg, genasi, githzerai, githyanki, gnome, svirfneblin, goblin, goliath, halfling, orc, halfOrc, harengon, hobgoblin, human, kenkuu, kobold, leonin, lizardfolk, minotaur, locathah, owlin, reborn, satyr, shifter, tabaxi, tiefling, tortle, triton, yuanTi };
            return typeRace;
        }
    }
    
        
}
