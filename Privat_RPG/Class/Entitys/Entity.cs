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

        public virtual void attack(int attackIndex, Entity target)
        {
            Attack selected = attacks[attackIndex];
            target.takeDamage(selected.Dmg);

            string output = selected.Description;
            output = output.Replace("ENTITY", this.Name);
            output = output.Replace("TARGET", target.Name);

            Console.WriteLine(string.Format(output + " {0,0} nimmt {1,0} Schaden", target.Name, selected.Dmg));
        }

        public virtual bool checkDeath()
        {
            return hp == 0;
        }

        public virtual void takeDamage(int dmg)
        {
            hp -= dmg; 

            if (hp < 0)
            {
                hp = 0;
            }
        }

        public virtual void update()
        {

        }
    }
}
