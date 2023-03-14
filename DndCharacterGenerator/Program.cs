using DndCharacterGenerator.DndObjects;
using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Xml.Linq;

namespace DndCharacterGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loop = true;
            do
            {
                var character = CharacterGenerator();
                Console.WriteLine();
                Console.WriteLine($"Do you want to save {character.CharacterName}? Y or N");
                var saveChar = Console.ReadLine();
                if (saveChar != null && saveChar.ToLower() == "y")
                    SaveCharacter(character);

                Console.WriteLine("Do you want to create a new character? Y or N ");
                var continueChar = Console.ReadLine();
                if (continueChar != null && continueChar.ToLower() == "n")
                    loop = false;
            } while (loop);
        }

        static void SaveCharacter(DndCharacter character)
        {
            var characterString = "";
            characterString += ($"Name: {character.CharacterName}\n");
            characterString += ($"Race: {character.CombinedRace}\n");
            characterString += ($"Age: {character.Age}\n");
            characterString += ($"Height: {character.Height}cm\n");
            characterString += ($"Weight: {character.Weight}kgs\n");
            characterString += ($"Class: {character.DndClass.ClassName}\n");
            characterString += ($"Subclass: {character.Subclass!.ClassName}\n");
            characterString += ($"Martial Weapon: {character.MartialWeapon!.MartialWeaponName}\n");
            characterString += ($"Simple Weapon: {character.SimpleWeapon!.SimpleWeaponName}\n");
            characterString += ($"Background: {character.DndBackground.BackgroundName}\n");
            characterString += ($"Skill Proficiency: {character.DndBackground.BackgroundSkillProf}\n");
            characterString += ($"Starting Equipment: {character.DndBackground.BackgroundEquip}\n");
            characterString += ($"Personality Trait: {character.BackgroundPersonality}\n");
            characterString += ($"Ideal: {character.BackgroundIdeal}\n");
            characterString += ($"Bond: {character.BackgroundBond}\n");
            characterString += ($"Flaw: {character.BackgroundFlaw}\n");
            File.WriteAllText($".\\{character.CharacterName}.txt", characterString);
            //please note this saves to bin/Debug/net6.0
        }

        static DndCharacter CharacterGenerator()
        {
            var typeRaces = Utility.GetTypeRace();
            var typeClasses = Utility.GetTypeClasses();
            var typeBackground = Utility.GetBackgrounds();
            var rnd = new Random();
            var race = typeRaces[rnd.Next(0, typeRaces.Count)];
            var typeClass = typeClasses[rnd.Next(0, typeClasses.Count)];
            var background = typeBackground[rnd.Next(0, typeBackground.Count)];

            Console.Write("What is the name of your character? ");
            var name = Console.ReadLine();
            Console.WriteLine("Thank you");
            Console.ReadLine();

            var character = new DndCharacter(name ?? "", race, typeClass, background);
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Race: {character.CombinedRace}");
            Console.WriteLine($"Age: {character.Age}");
            Console.WriteLine($"Height: {character.Height}cm");
            Console.WriteLine($"Weight: {character.Weight}kgs");
            Console.WriteLine($"Class: {typeClass.ClassName}");
            Console.WriteLine($"Subclass: {character.Subclass!.ClassName}");
            Console.WriteLine($"Martial Weapon: {character.MartialWeapon!.MartialWeaponName}");
            Console.WriteLine($"Simple Weapon: {character.SimpleWeapon!.SimpleWeaponName}");
            Console.WriteLine($"Background: {character.DndBackground.BackgroundName}");
            Console.WriteLine($"Skill Proficiency: {character.DndBackground.BackgroundSkillProf}");
            Console.WriteLine($"Starting Equipment: {character.DndBackground.BackgroundEquip}");
            Console.WriteLine($"Personality Trait: {character.BackgroundPersonality}");
            Console.WriteLine($"Ideal: {character.BackgroundIdeal}");
            Console.WriteLine($"Bond: {character.BackgroundBond}");
            Console.WriteLine($"Flaw: {character.BackgroundFlaw}");
            return character;
        }
    }
}

