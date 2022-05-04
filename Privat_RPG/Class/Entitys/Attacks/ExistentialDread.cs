using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class ExistentialDread:Attack
    {
        static string[] descriptions = new string[] { "ENTITY zweifelt an sich selbst. TARGET fühlt Mitleid.", "ENTITY beginnt, sich mental selbst fertig zu machen. TARGET ist berührt.", "ENTITY ist fertig mit der Welt und braucht einen Psychiater. TARGET ist leider keiner." };
        public override void update()
        {
            Description = descriptions[random.Next(0, descriptions.Length)];
        }

        public ExistentialDread()
        {
            DmgMAX = 3;
            DmgMIN = 0;
            Acc = 100;
            Name = "Existential Dread";
            Crit = 5;
            update();
        }
    }
}
