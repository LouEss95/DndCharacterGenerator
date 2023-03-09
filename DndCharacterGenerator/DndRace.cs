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

            //move to own file
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
            else if (typeRace == "Genasi")
            {
                RaceHeight = rnd.Next(152, 190);
                RaceAge = rnd.Next(19, 100);
                RaceWeight = rnd.Next(59, 102);
            }
            else if (typeRace == "Githzerai" || typeRace == "Githyanki")
            {
                RaceHeight = rnd.Next(155, 213);
                RaceAge = rnd.Next(19, 100);
                RaceWeight = rnd.Next(42, 89);
            }
            else if (typeRace == "Gnome" || typeRace == "Svirfneblin")
            {
                RaceHeight = rnd.Next(91, 122);
                RaceAge = rnd.Next(40, 400);
                RaceWeight = rnd.Next(16, 21);
            }
            else if (typeRace == "Goblin")
            {
                RaceHeight = rnd.Next(91, 122);
                RaceAge = rnd.Next(8, 50);
                RaceWeight = rnd.Next(18, 36);
            }
            else if (typeRace == "Goliath")
            {
                RaceHeight = rnd.Next(213, 244);
                RaceAge = rnd.Next(19, 85);
                RaceWeight = rnd.Next(127, 154);
            }
            else if (typeRace == "Halfling")
            {
                RaceHeight = rnd.Next(86, 101);
                RaceAge = rnd.Next(20, 230);
                RaceWeight = rnd.Next(16, 20);
            }
            else if (typeRace == "Orc")
            {
                RaceHeight = rnd.Next(183, 203);
                RaceAge = rnd.Next(12, 40);
                RaceWeight = rnd.Next(104, 127);
            }
            else if (typeRace == "Half-Orc")
            {
                RaceHeight = rnd.Next(168, 198);
                RaceAge = rnd.Next(14, 60);
                RaceWeight = rnd.Next(104, 127);
            }
            else if (typeRace == "Harengon")
            {
                RaceHeight = rnd.Next(76, 228);
                RaceAge = rnd.Next(19, 85);
                RaceWeight = rnd.Next(29, 120);
            }
            else if (typeRace == "Hobgoblin")
            {
                RaceHeight = rnd.Next(152, 183);
                RaceAge = rnd.Next(19, 85);
                RaceWeight = rnd.Next(68, 91);
            }
            else if (typeRace == "Human")
            {
                RaceHeight = rnd.Next(147, 199);
                RaceAge = rnd.Next(19, 85);
                RaceWeight = rnd.Next(68, 91);
            }
            else if (typeRace == "Kenkuu")
            {
                RaceHeight = rnd.Next(147, 160);
                RaceAge = rnd.Next(12, 50);
                RaceWeight = rnd.Next(54, 90);
            }
            else if (typeRace == "Kobold")
            {
                RaceHeight = rnd.Next(61, 92);
                RaceAge = rnd.Next(6, 100);
                RaceWeight = rnd.Next(11, 16);
            }
            else if (typeRace == "Leonin")
            {
                RaceHeight = rnd.Next(183, 226);
                RaceAge = rnd.Next(19, 85);
                RaceWeight = rnd.Next(84, 125);
            }
            else if (typeRace == "Lizardfolk")
            {
                RaceHeight = rnd.Next(183, 213);
                RaceAge = rnd.Next(14, 50);
                RaceWeight = rnd.Next(95, 104);
            }
            else if (typeRace == "Minotaur")
            {
                RaceHeight = rnd.Next(193, 216);
                RaceAge = rnd.Next(19, 85);
                RaceWeight = rnd.Next(132, 145);
            }
            else if (typeRace == "Locathah")
            {
                RaceHeight = rnd.Next(152, 182);
                RaceAge = rnd.Next(10, 70);
                RaceWeight = rnd.Next(59, 68);
            }
            else if (typeRace == "Owlin")
            {
                RaceHeight = rnd.Next(142, 165);
                RaceAge = rnd.Next(19, 85);
                RaceWeight = rnd.Next(45, 68);
            }
            else if (typeRace == "Reborn")
            {
                RaceHeight = rnd.Next(135, 170);
                RaceAge = rnd.Next(25, 1500);
                RaceWeight = rnd.Next(55, 97);
            }
            else if (typeRace == "Satyr")
            {
                RaceHeight = rnd.Next(147, 160);
                RaceAge = rnd.Next(19, 85);
                RaceWeight = rnd.Next(68, 77);
            }
            else if (typeRace == "Shifter")
            {
                RaceHeight = rnd.Next(170, 180);
                RaceAge = rnd.Next(10, 60);
                RaceWeight = rnd.Next(59, 81);
            }
            else if (typeRace == "Tabaxi")
            {
                RaceHeight = rnd.Next(160, 198);
                RaceAge = rnd.Next(19, 85);
                RaceWeight = rnd.Next(61, 66);
            }
            else if (typeRace == "Tiefling")
            {
                RaceHeight = rnd.Next(170, 198);
                RaceAge = rnd.Next(19, 110);
                RaceWeight = rnd.Next(54, 86);
            }
            else if (typeRace == "Tortle")
            {
                RaceHeight = rnd.Next(152, 182);
                RaceAge = rnd.Next(15, 45);
                RaceWeight = rnd.Next(190, 209);
            }
            else if (typeRace == "Triton")
            {
                RaceHeight = rnd.Next(147, 158);
                RaceAge = rnd.Next(15, 180);
                RaceWeight = rnd.Next(43, 84);
            }
            else if (typeRace == "Yuan-Ti")
            {
                RaceHeight = rnd.Next(139, 198);
                RaceAge = rnd.Next(19, 85);
                RaceWeight = rnd.Next(41, 127);
            }
        }

        public string TypeRace { get; set; }
        public string[] SubRace { get; set;}
        public int RaceHeight { get;set;}
        public int RaceAge { get; set;}
        public int RaceWeight { get; set;}
    }
}
