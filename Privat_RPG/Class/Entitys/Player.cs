using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Player:Entity
    {
        public Player(string name)
        {
            Hp = 100;
            Lvl = 1;
            Attacks = new Attack[] { new SwordWield(), new Slap(), new Eat() };
            Name = name;
        }
    }
}
