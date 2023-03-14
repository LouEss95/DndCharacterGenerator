using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterGenerator.DndObjects
{
    public class DndClass
    {
        public string? ClassName { get; set; }
        public string? HitDice { get; set; }
        public string? ArmourProf { get; set; }
        public string? WeaponProf { get; set; }
        public string? ClassTools { get; set; }
        public string? SavingThrows { get; set; }
        public string? AdditionalSkills { get; set; }
        public string? Resource { get; set; }
        public string? ClassEquip { get; set; }
        public List<DndMartialWeapons>? MartialWeapons { get; set; }
        public List<DndSimpleWeapons>? SimpleWeapons { get; set; }
        public List<DndSubclasses>? SubClasses { get; set; }

    }

}
