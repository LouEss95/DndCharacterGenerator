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
            var typeRace = Utility.GetTypeRace();
            var typeClasses = Utility.GetTypeClasses();
            var rnd = new Random();
            var raceIndex = rnd.Next(0, typeRace.Length);
            var subRaceIndex = rnd.Next(0, typeRace[raceIndex].SubRace.Length);
            var classIndex = rnd.Next(0, typeClasses.Length);
            var subClassIndex = rnd.Next(0, typeClasses[classIndex].SubClass.Length);

            var subRace = "";
            if (typeRace[raceIndex].SubRace != null && typeRace[raceIndex].SubRace.Length > 0)
            {
                subRace = typeRace[raceIndex].SubRace[subRaceIndex];
            }

            var race = typeRace[raceIndex].TypeRace;
            var subClass = typeClasses[classIndex].SubClass[subClassIndex];
            var typeClass = typeClasses[classIndex].TypeClass;
            var height = typeRace[raceIndex].RaceHeight;
            var age = typeRace[raceIndex].RaceAge;
            var weight = typeRace[raceIndex].RaceWeight;

            Console.Write("What is the name of your character? ");
            var name = Console.ReadLine();
            Console.WriteLine("Thank you");
            Console.ReadLine();

            var raceClass = $"{age} year old {subRace}{race} and a(n) {subClass} {typeClass} ";
            Console.WriteLine($"{name} is a {raceClass}. They are {height}cm tall and weigh {weight}kgs.");
        }
    }
}

