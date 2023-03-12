using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DndCharacterGenerator.DndObjects;

namespace DndCharacterGenerator
{
    public static class Utility
    {
        public static List<DndClass> GetTypeClasses()
        {
            using StreamReader reader = new("JSON/DndClasses.json");
            var json = reader.ReadToEnd();
            var dndClasses = JsonSerializer.Deserialize<List<DndClass>>(json);
            if (dndClasses == null)
            {
                return new List<DndClass>();
            }
            return dndClasses;
        }
        public static List<DndRace> GetTypeRace()
        { 
            using StreamReader reader = new("JSON/DndRaces.json");
            var json = reader.ReadToEnd();
            var dndRaces = JsonSerializer.Deserialize<List<DndRace>>(json);
            if(dndRaces == null)
            {
                return new List<DndRace>();
            }
            return dndRaces;
        }
        public static List<DndBackgrounds> GetBackgrounds()
        {
            using StreamReader reader = new("JSON/DndBackgrounds.json");
            var json = reader.ReadToEnd();
            var dndBackgrounds = JsonSerializer.Deserialize<List<DndBackgrounds>>(json);
            if (dndBackgrounds == null)
            {
                return new List<DndBackgrounds>();
            }
            return dndBackgrounds;
        }
    }     
}
