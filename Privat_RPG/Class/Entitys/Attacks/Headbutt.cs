using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Headbutt:Attack
    {
        public Headbutt()
        {
            Name = "Kopfnuss";
            Acc = 99;
            DmgMAX = 3;
            DmgMIN = 2;
            Crit = 20;
            Description = "ENTITY gibt TARGET eine Kopfnuss.";
        }
    }
}
