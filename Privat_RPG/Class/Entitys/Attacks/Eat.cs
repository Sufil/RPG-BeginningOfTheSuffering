using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Eat:Attack
    {
        public Eat()
        {
            DmgMAX = 1;
            DmgMIN = 0;
            Acc = 30;
            Name = "Essen";
            Crit = 5;
            Description = "ENTITY nimmt einen Bissen aus TARGET.";
        }
    }
}
