using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class SwordWield:Attack
    {
        public SwordWield()
        {
            Name = "Schwertschlag";
            Acc = 96;
            Dmg = 4;
            Crit = 5;
            Description = "ENTITY schwingt das Schwert in heroischer Miene als gäbe es ein Morgen. Dabei trifft ENTITY aus Versehen TARGET.";
        }
    }
}
