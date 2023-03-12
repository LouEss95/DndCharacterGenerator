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
        public List<DndSubclasses>? SubClasses { get; set; }

    }

}
