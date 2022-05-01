using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Blobfish:Enemy
    {
        public override void update()
        {
            foreach (Attack attack in Attacks)
            {
                attack.update();
            }
        }

        public Blobfish()
        {
            Hp = 30;
            Lvl = 2;
            Name = "Blobfisch";
            Exp = 5;
            DeathOutput = "Der Blobfish versinkt in Hass, Trauer und Angst. Er ist tot.";

            Attacks = new Attack[] { new ExistentialDread(), new Cry() };
            AmountAttacks = Attacks.Length;
            ProbabilityOfAppearing = 10;
        }
    }
}
