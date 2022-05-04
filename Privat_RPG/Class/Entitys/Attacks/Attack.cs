using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Attack
    {
        int dmgMAX;
        int dmgMIN;
        int acc;
        string name;
        int crit;
        public Random random = new Random();

        bool specialEffect = false;

        string description;

        public int Acc { get => acc; set => acc = value; }
        public string Name { get => name; set => name = value; }
        public bool SpecialEffect { get => specialEffect; set => specialEffect = value; }
        public int DmgMAX { get => dmgMAX; set => dmgMAX = value; }
        public int DmgMIN { get => dmgMIN; set => dmgMIN = value; }
        public int Crit { get => crit; set => crit = value; }
        public string Description { get => description; set => description = value; }

        public virtual int getDamage()
        {
            int dmg = random.Next(dmgMIN, dmgMAX + 1);
            //Description = getDescription(dmg);    -Funktioniert noch nicht-
            return dmg;
        }

        public virtual string getDescription(int dmg)
        {
            return "";
        }
        public virtual void update()
        {

        }

        public virtual void updateAttack()
        {

        }
    }
}
