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

        public Player(string name)
        {
            Hp = 100;
            Lvl = 1;
            Attacks = new Attack[] { new SwordWield(), new Slap(), new Eat() };
            Name = name;

        }
    }
}
