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
            DmgMAX = 2;
            DmgMIN = 0;
            Acc = 100;
            Name = "Schlag";
            Crit = 15;
            Description = "ENTITY schlägt TARGET.";
        }
    }
}
