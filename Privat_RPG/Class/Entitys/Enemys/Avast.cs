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
            Hp = 10;
            Lvl = 1;
            Name = "Avast";
            Exp = 2;
            DeathOutput = "Avast löst sich in Luft auf.";

            Attacks = new Attack[] { new Slap(), new Headbutt() };
            AmountAttacks = Attacks.Length;
            ProbabilityOfAppearing = 10;
        }
    }
}
