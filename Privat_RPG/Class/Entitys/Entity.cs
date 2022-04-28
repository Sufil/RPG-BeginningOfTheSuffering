using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Entity
    {
        int hp;
        int lvl;
        string name;
        Attack[] attacks;
        public int Hp { get => hp; set => hp = value; }
        public string Name { get => name; set => name = value; }
        public int Lvl { get => lvl; set => lvl = value; }
        public Attack[] Attacks { get => attacks; set => attacks = value; }

        public virtual void attack(Entity target)
        {
            Random random = new Random();
            Attack selected = attacks[random.Next(0, attacks.Length)];
            target.takeDamage(selected.Dmg);
            Console.WriteLine(string.Format("{0,0} setzt {1,0} ein. {2,0} nimmt {3,0} Schaden", this.Name, selected.Name, target.Name, selected.Dmg));
        }

        public virtual void takeDamage(int dmg)
        {
            this.hp -= dmg; 

            if (hp < 0)
            {
                hp = 0;
            }
        }
    }
}
