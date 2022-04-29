using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Slap:Attack
    {
        public Slap()
        {
            Dmg = 2;
            Acc = 100;
            Name = "Schlag";
            Crit = 15;
            Description = "ENTITY schlägt TARGET.";
        }
    }
}
