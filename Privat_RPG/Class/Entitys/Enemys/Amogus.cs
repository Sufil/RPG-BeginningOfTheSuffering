using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Amogus:Enemy
    {

        public override string appears()
        {
            return "Du hörst ein suspektes Geräusch hinter dir. Du drehst dich um, vor dir ein Eumel. Kämpft!";
        }

        public Amogus()
        {
            Hp = 12;
            Lvl = 3;
            Name = "Eumel";
            Exp = 10;
            DeathOutput = "The Impostor has been ejected.";

            Attacks = new Attack[] { new Sus(), new Shoot(), new Ambush() };
            AmountAttacks = Attacks.Length;
            ProbabilityOfAppearing = 10;
        }
    }
}
