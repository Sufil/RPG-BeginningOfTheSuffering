using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Player:Entity
    {
        private int neededExp = 20;
        private int currentExp = 0;

        private double str = 1;
       

        public int NeededExp { get { return neededExp; } set { neededExp = value; } }
        public int CurrentExp { get { return currentExp; } set { currentExp = value; } }
        public double Str { get { return str; } set { str = value; } }

        public virtual void addExp(Enemy slayed)
        {
            currentExp += slayed.Exp;

            if (currentExp >= neededExp)
            {
                lvlUp();
            }
        }

        public virtual void lvlUp()
        {
            neededExp = (int)(neededExp * 1.5);
            currentExp = 0;
            // Verschiedene Möglichkeiten zum Skillen, vorerst jedoch:
            Str *= 1.5;
            Console.WriteLine("Du hast ein Lvl Up erhalten! Stärke um 50% erhöht!");
        }

        public override void attack(int attackIndex, Entity target)
        {
            Attack selected = Attacks[attackIndex];
            int dmg = selected.getDamage();
            double damage = dmg * Str;
            target.takeDamage(dmg);

            string output = selected.Description;
            output = output.Replace("ENTITY", this.Name);
            output = output.Replace("TARGET", target.Name);

            Console.WriteLine(string.Format(output + " {0,0} nimmt {1,0} Schaden", target.Name, damage));
        }

        public Player(string name)
        {
            Hp = 100;
            Lvl = 1;
            Attacks = new Attack[] { new SwordWield(), new Slap(), new Eat() };
            Name = name;

        }
    }
}
