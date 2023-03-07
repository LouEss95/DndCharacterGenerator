using System;
using System.Runtime.InteropServices;

namespace DndCharacterGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loop = true;
            do
            {
                CharacterGenerator();
                Console.WriteLine("Do you want to create a new character? Y or N ");
                var continueChar = Console.ReadLine();
                if (continueChar == "N")
                {
                    loop = false;
                }

            } while (loop);
        }

        static void CharacterGenerator()
        {
            var race = new String[]
                { "Dragonborn", "Dwarf","Elf","Gnome","Half-Elf","Halfling","Half-Orc","Human","Tiefling","Aarakocran","Air Genasi","Fire Genasi","Earth Genasi","Water Genasi","Changeling","Bugbear","Deep Gnome","Duergar", "Eladrin", "Fairy", "Firbolg","Githyanki","Githzerai","Goblin","Goliath","Harengon","Hob-Goblin","Kenkuu","Kobold","Aasimar","Lizardfolk","Minotaur","Orc", "Satyr","Sea Elf", "Shadar-Kai","Shifter","Tabaxi","Tortle","Triton","Yuan-ti","Warforged"};
            var typeClass = Utility.GetTypeClasses();
            var rnd = new Random();
            var raceIndex = rnd.Next(0, race.Length);
            var classIndex = rnd.Next(0, typeClass.Length);
            var subClassIndex = rnd.Next(0, typeClass[classIndex].SubClass.Length);

            var raceClass = $"{race[raceIndex]} {typeClass[classIndex].TypeClass} {typeClass[classIndex].SubClass[subClassIndex]}";

            Console.Write("What is the name of your character? ");
            var name = Console.ReadLine();
            Console.WriteLine("Thank you");
            Console.ReadLine();
            Console.WriteLine($"{name} is a(n) {raceClass}");
        }
    }
}

