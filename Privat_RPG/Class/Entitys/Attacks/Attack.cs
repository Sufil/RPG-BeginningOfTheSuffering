using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Attack
    {
        int dmg;
        int acc;
        string name;
        int crit;
        public Random random = new Random();

        bool specialEffect = false;

        string description;

        public int Acc { get => acc; set => acc = value; }
        public string Name { get => name; set => name = value; }
        public bool SpecialEffect { get => specialEffect; set => specialEffect = value; }
        public int Dmg { get => dmg; set => dmg = value; }
        public int Crit { get => crit; set => crit = value; }
        public string Description { get => description; set => description = value; }

        public virtual void update()
        {

        }
    }
}
