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
                    loop = false;
            } while (loop);
        }

        static void CharacterGenerator()
        {
            var typeRace = Utility.GetTypeRace();
            var typeClasses = Utility.GetTypeClasses();
            var rnd = new Random();
            var raceIndex = rnd.Next(0, typeRace.Count);
            var classIndex = rnd.Next(0, typeClasses.Count);

            var subRace = "";
            var subRaces = typeRace[raceIndex].Subraces;
            if (subRaces != null && subRaces.Count > 0)
            {
                var subRaceIndex = rnd.Next(0, typeRace[raceIndex]!.Subraces!.Count);
                subRace = subRaces[subRaceIndex]!.RaceName;
            }
            var subClass = "";
            var subClasses = typeClasses[classIndex].SubClasses;
            if (subClasses != null && subClasses.Count > 0)
            {
                var subClassIndex = rnd.Next(0, typeClasses[classIndex]!.SubClasses!.Count);
                subClass = subClasses[subClassIndex]!.ClassName;
            }

            var race = typeRace[raceIndex];
            var typeClass = typeClasses[classIndex].ClassName;
            var height = rnd.Next(race.MinHeight, race.MaxHeight);
            var age = rnd.Next(race.MinAge, race.MaxAge);
            var weight = rnd.Next(race.MinWeight, race.MaxWeight);

            Console.Write("What is the name of your character? ");
            var name = Console.ReadLine();
            Console.WriteLine("Thank you");
            Console.ReadLine();

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Race: {subRace}{race.RaceName}");
            Console.WriteLine($"Class: {typeClass}");
            Console.WriteLine($"Subclass: {subClass}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}cm");
            Console.WriteLine($"Weight: {weight}kgs");
        }
    }
}

