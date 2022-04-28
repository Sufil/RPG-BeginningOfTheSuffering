using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Avast:Enemy
    {
        public Avast()
        {
            Hp = 100;
            Lvl = 1;
            Name = "Avast";

            Attacks = new Attack[] { new Slap(), new Headbutt() };
            ProbabilityOfAppearing = 100;
        }
    }
}
