using DndCharacterGenerator.DndObjects;
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
                if (continueChar != null && continueChar.ToLower() == "n")
                    loop = false;
            } while (loop);
        }

        static void CharacterGenerator()
        {
            var typeRaces = Utility.GetTypeRace();
            var typeClasses = Utility.GetTypeClasses();
            var typeBackground = Utility.GetBackgrounds();
            var rnd = new Random();
            var race = typeRaces[rnd.Next(0, typeRaces.Count)];
            var typeClass = typeClasses[rnd.Next(0, typeClasses.Count)];
            var background = typeBackground[rnd.Next(0, typeBackground.Count)];

            var character = new DndCharacter(race, typeClass, background);
            Console.Write("What is the name of your character? ");
            var name = Console.ReadLine();
            Console.WriteLine("Thank you");
            Console.ReadLine();

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Race: {character.CombinedRace}");
            Console.WriteLine($"Class: {typeClass.ClassName}");
            Console.WriteLine($"Subclass: {character.Subclass!.ClassName}");
            Console.WriteLine($"Age: {character.Age}");
            Console.WriteLine($"Height: {character.Height}cm");
            Console.WriteLine($"Weight: {character.Weight}kgs");
            Console.WriteLine($"Background: {character.DndBackground.BackgroundName}");
            Console.WriteLine($"Skill Proficiency: {character.DndBackground.BackgroundSkillProf}");
            Console.WriteLine($"Starting Equipment: {character.DndBackground.BackgroundEquip}");
            Console.WriteLine($"Personality Trait: {character.BackgroundPersonality}");
            Console.WriteLine($"Ideal: {character.BackgroundIdeal}");
            Console.WriteLine($"Bond: {character.BackgroundBond}");
            Console.WriteLine($"Flaw: {character.BackgroundFlaw}");
        }
    }
}

