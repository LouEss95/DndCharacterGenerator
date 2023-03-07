using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterGenerator
{
    public class DndClass
    {
        public DndClass(string typeClass, string[] subClass)
        {
            TypeClass = typeClass;
            SubClass = subClass;
        }
        public string TypeClass { get; set; }
        public string[] SubClass { get; set; }
    }
}
