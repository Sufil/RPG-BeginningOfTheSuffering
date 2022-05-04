using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Shoot:Attack
    {
        public Shoot()
        {
            DmgMAX = 15;
            DmgMIN = 10;
            Name = "Schuss";
            Crit = 5;
            Description = "ENTITY zieht eine Waffe und schießt auf TARGET.";
        }
    }
}
