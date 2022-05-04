using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privat_RPG
{
    class Enemy:Entity
    {
        static int probabilityOfAppearing;
        int exp;
        string deathOutput;

        Attack[] possibleAttacks;
        int amountAttacks;
        Attack[] attacks;
        
        public static int ProbabilityOfAppearing { get => probabilityOfAppearing; set => probabilityOfAppearing = value; }
        public int Exp { get => exp; set => exp = value; }
        public int AmountAttacks { get => amountAttacks; set => amountAttacks = value; }
        public string DeathOutput { get => deathOutput; set => deathOutput = value; }

        public virtual string appears()
        {
            return "";
        }

        public virtual int selectAttack()
        {
            Random random = new Random();
            return random.Next(0, amountAttacks);  
        }        
    }
}
