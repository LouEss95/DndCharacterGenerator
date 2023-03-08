using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterGenerator
{
    public class DndRace
    {
        public DndRace(string typeRace, string[] subRace)
        {
            TypeRace = typeRace;
            SubRace = subRace;

            var rnd = new Random();
            if (typeRace == "Dragonborn")
            {
                RaceHeight = rnd.Next(172, 208);
                RaceAge = rnd.Next(19, 65);
                RaceWeight = rnd.Next(100, 150);
            }
            else if (typeRace == "Aarakocran")
            {
                RaceHeight = rnd.Next(152, 160);
                RaceAge = rnd.Next(3, 20);
                RaceWeight = rnd.Next(36, 45);
            }
            else if (typeRace == "Aasimar")
            {
                RaceHeight = rnd.Next(140, 200);
                RaceAge = rnd.Next(19, 145);
                RaceWeight = rnd.Next(40, 111);
            }
            else if (typeRace == "Bugbear")
            {
                RaceHeight = rnd.Next(183, 244);
                RaceAge = rnd.Next(16, 70);
                RaceWeight = rnd.Next(114, 159);
            }
            else if (typeRace == "Centaur")
            {
                RaceHeight = rnd.Next(213, 274);
                RaceAge = rnd.Next(3, 450);
                RaceWeight = rnd.Next(900, 950);
            }
            else if (typeRace == "Changeling")
            {
                RaceHeight = rnd.Next(152, 182);
                RaceAge = rnd.Next(16, 85);
                RaceWeight = rnd.Next(59, 100);
            }
            else if (typeRace == "Dwarf" || typeRace == "Duergar")
            {
                RaceHeight = rnd.Next(122, 152);
                RaceAge = rnd.Next(50, 335);
                RaceWeight = rnd.Next(63, 68);
            }
            else if (typeRace == "Elf")
            {
                RaceHeight = rnd.Next(147, 193);
                RaceAge = rnd.Next(101, 730);
                RaceWeight = rnd.Next(45, 66);
            }
            else if (typeRace == "Half-Elf")
            {
                RaceHeight = rnd.Next(147, 193);
                RaceAge = rnd.Next(20, 180);
                RaceWeight = rnd.Next(45, 82);
            }
            else if (typeRace == "Fairy")
            {
                RaceHeight = rnd.Next(91, 122);
                RaceAge = rnd.Next(40, 800);
                RaceWeight = rnd.Next(14, 18);
            }
            else if (typeRace == "Firbolg")
            {
                RaceHeight = rnd.Next(213, 244);
                RaceAge = rnd.Next(30, 480);
                RaceWeight = rnd.Next(109, 130);
            }
        }

        public string TypeRace { get; set; }
        public string[] SubRace { get; set;}
        public int RaceHeight { get;set;}
        public int RaceAge { get; set;}
        public int RaceWeight { get; set;}
    }
}
