using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Sus:Attack
    {
        public Sus()
        {
            Dmg = 2;
            Acc = 30;
            Name = "Sus";
            Crit = 5;
            Description = "ENTITY schreit, TARGET sei sus. Einige Menschen drehten ihren Kopf in TARGETs Richtung, was TARGET äußerst unangenehm war.";
        }
    }
}
