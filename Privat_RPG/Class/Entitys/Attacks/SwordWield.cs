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
            Dmg = 40;
            Crit = 5;
            Description = "ENTITY schwingt sein langes Schwert und erzeugt bei TARGET eine tiefe Fleischwunde und enormen Schmerz.";
        }
    }
}
