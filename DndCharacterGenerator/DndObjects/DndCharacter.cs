using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterGenerator.DndObjects
{
    public class DndCharacter
    {
        public DndCharacter(string name, DndRace dndRace, DndClass dndClass, DndBackgrounds dndBackgrounds)
        {
            CharacterName = name;
            DndRace = dndRace;
            DndClass = dndClass;
            DndBackground = dndBackgrounds;

            var rnd = new Random();
            var subRaces = DndRace.Subraces;
            if (subRaces != null && subRaces.Count > 0)
            {
                Subrace = subRaces[rnd.Next(0, DndRace!.Subraces!.Count)];
            }

            var subClasses = DndClass.SubClasses;
            if (subClasses != null && subClasses.Count > 0)
            {
                Subclass = subClasses[rnd.Next(0, DndClass!.SubClasses!.Count)];
            }

            var backgroundPersonalities = DndBackground.BackgroundPersonalities;
            if (backgroundPersonalities != null && backgroundPersonalities.Count > 0)
            {
                BackgroundPersonality = backgroundPersonalities[rnd.Next(0, backgroundPersonalities.Count)];
            }

            var backgroundIdeals = DndBackground.BackgroundIdeals;
            if (backgroundIdeals != null && backgroundIdeals.Count > 0)
            {
                BackgroundIdeal = backgroundIdeals[rnd.Next(0, backgroundIdeals.Count)];
            }

            var backgroundBonds = DndBackground.BackgroundBonds;
            if (backgroundBonds != null && backgroundBonds.Count > 0)
            {
                BackgroundBond = backgroundBonds[rnd.Next(0, backgroundBonds.Count)];
            }

            var backgroundFlaws = DndBackground.BackgroundFlaws;
            if (backgroundFlaws != null && backgroundFlaws.Count > 0)
            {
                BackgroundFlaw = backgroundFlaws[rnd.Next(0, backgroundFlaws.Count)];
            }

            var martialWeapons = DndClass.MartialWeapons;
            if (martialWeapons != null && martialWeapons.Count > 0)
            {
                MartialWeapon = martialWeapons[rnd.Next(0, DndClass!.MartialWeapons!.Count)];
            }
            else if (martialWeapons == null || martialWeapons.Count == 0)
                MartialWeapon = new DndMartialWeapons { MartialWeaponName = "N/A" };

            var simpleWeapons = DndClass.SimpleWeapons;
            if (simpleWeapons != null && simpleWeapons.Count > 0)
            {
                SimpleWeapon = simpleWeapons[rnd.Next(0, DndClass!.SimpleWeapons!.Count)];
            }
            else if (simpleWeapons == null || simpleWeapons.Count == 0)
                SimpleWeapon = new DndSimpleWeapons { SimpleWeaponName = "N/A" };

            Height = rnd.Next(DndRace.MinHeight, DndRace.MaxHeight);
            Age = rnd.Next(DndRace.MinAge, DndRace.MaxAge);
            Weight = rnd.Next(DndRace.MinWeight, DndRace.MaxWeight);
        }

        public DndRace DndRace { get; set; }
        public DndSubraces? Subrace { get; set; }
        public DndClass DndClass { get; set; }
        public DndSubclasses? Subclass { get; set; }
        public DndBackgrounds DndBackground { get; set; }
        public int? Age { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public string? BackgroundPersonality { get; set; }
        public string? BackgroundIdeal { get; set; }
        public string? BackgroundBond { get; set; }
        public string? BackgroundFlaw { get; set; }
        public string? CharacterName { get; set; }
        public DndMartialWeapons? MartialWeapon { get; set; }
        public DndSimpleWeapons? SimpleWeapon { get; set; }

        public string CombinedRace
        {
            get
            {
                if (Subrace != null)
                    return $"{Subrace.RaceName} {DndRace.RaceName}";
                else if (DndRace.RaceName != null)
                    return DndRace.RaceName;

                return "";
            }
        }
    }
}
